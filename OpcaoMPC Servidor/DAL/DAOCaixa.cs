using Controle;
using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;

namespace OpcaoMPCServidor.DAL
{
    public class DAOCaixa : IDAODatado<Caixa>
    {
        #region Implementação

        public bool Atualizar(Caixa entidade, ulong usuario = Util.Usuario.SISTEMA)
        {
            bool res = false;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
update caixa
   set valor_em_caixa = @ValorEmCaixa
     , data           = @Data
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@ValorEmCaixa", NpgsqlDbType.Real));
                    com.Parameters.Add(new NpgsqlParameter("@Data", NpgsqlDbType.Date));
                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    com.Parameters["@ValorEmCaixa"].Value = entidade.ValorEmCaixa;
                    com.Parameters["@Data"].Value         = entidade.Data;
                    com.Parameters["@Codigo"].Value       = entidade.Codigo;

                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Caixa, Util.Acao.UPDATE, com);

                        LogSistema.AdicionarEvento($"Caixa de código '{entidade.Codigo}' atualizada com sucesso");
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception ex)
            {
                res = false;

                LogSistema.AdicionarEvento($"Erro ao atualizar Caixa: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public Caixa Buscar(ulong codigo)
        {
            Caixa res = null;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }
                
                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
select codigo, valor_em_caixa, data
  from caixa
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    com.Parameters["@Codigo"].Value = codigo;

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            res = new Caixa
                            {
                                Codigo       = Convert.ToUInt64(reader["codigo"].ToString()),
                                ValorEmCaixa = Convert.ToSingle(reader["valor_em_caixa"].ToString()),
                                Data         = Convert.ToDateTime(reader["data"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Caixa: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public List<Caixa> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            List<Caixa> res = null;

            if (inicio > fim)
            {
                DateTime aux;
                aux    = fim;
                fim    = inicio;
                inicio = aux;
            }
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = $@"
select codigo, valor_em_caixa, data
  from caixa
 where data <@ daterange('[{inicio.ToString("yyyy-MM-dd")}, { fim.ToString("yyyy-MM-dd")}]')
 order by data asc;";

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = new List<Caixa>();

                            while (reader.Read())
                            {
                                Caixa linha = new Caixa
                                {
                                    Codigo       = Convert.ToUInt64(reader["codigo"].ToString()),
                                    ValorEmCaixa = Convert.ToSingle(reader["valor_em_caixa"].ToString()),
                                    Data         = Convert.ToDateTime(reader["data"].ToString())
                                };
                                res.Add(linha);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Caixas: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public List<Caixa> BuscarPorData(DateTime data)
        {
            List<Caixa> res = null;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
select codigo, valor_em_caixa, data
  from caixa
 where data = @Data;";

                    com.Parameters.Add(new NpgsqlParameter("@Data", NpgsqlDbType.Date));

                    com.Parameters["@Data"].Value = data;
                    
                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = new List<Caixa>();

                            while (reader.Read())
                            {
                                Caixa linha = new Caixa
                                {
                                    Codigo       = Convert.ToUInt64(reader["codigo"].ToString()),
                                    ValorEmCaixa = Convert.ToSingle(reader["valor_em_caixa"].ToString()),
                                    Data         = Convert.ToDateTime(reader["data"].ToString())
                                };
                                res.Add(linha);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Caixas: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public Caixa Inserir(Caixa entidade, ulong usuario = Util.Usuario.SISTEMA)
        {
            Caixa res = null;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
insert into caixa (valor_em_caixa, data)
values (@ValorEmCaixa, @Data) returning codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@ValorEmCaixa", NpgsqlDbType.Real));
                    com.Parameters.Add(new NpgsqlParameter("@Data", NpgsqlDbType.Date));

                    com.Parameters["@ValorEmCaixa"].Value = entidade.ValorEmCaixa;
                    com.Parameters["@Data"].Value         = entidade.Data;

                    Object retorno = com.ExecuteScalar();

                    if (retorno == null)
                    {
                        res = null;
                    }
                    else
                    {
                        UInt64 codigo = Convert.ToUInt64(retorno.ToString());

                        res = entidade;

                        res.Codigo = codigo;

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Caixa, Util.Acao.INSERT, com);

                        LogSistema.AdicionarEvento($"Caixa de código '{codigo}' inserida com sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao inserir novo Caixa: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public List<Caixa> ListarTodos()
        {
            List<Caixa> res = null;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
select codigo, valor_em_caixa, data
  from caixa;";

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = new List<Caixa>();

                            while (reader.Read())
                            {
                                Caixa linha = new Caixa
                                {
                                    Codigo       = Convert.ToUInt64(reader["codigo"].ToString()),
                                    ValorEmCaixa = Convert.ToSingle(reader["valor_em_caixa"].ToString()),
                                    Data         = Convert.ToDateTime(reader["data"].ToString())
                                };
                                res.Add(linha);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao listar Caixas: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }
        #endregion
    }
}
