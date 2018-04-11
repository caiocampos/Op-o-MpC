using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;
using Controle;
using Npgsql;
using System.Data;
using NpgsqlTypes;
using OpcaoMPCServidor.Controle;

namespace OpcaoMPCServidor.DAL
{
    public class DAOFuncionario : IDAONomeado<Funcionario>, IDAORemovivel<Funcionario>
    {
        #region Implementação

        public bool Atualizar(Funcionario entidade, ulong usuario)
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
update funcionario
   set nome             = @Nome
     , usuario          = @Usuario
     , comissionado     = @Comissionado
     , funcao           = @Funcao
     , salario          = @Salario
     , ultimo_pagamento = @UltimoPagamento
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Nome", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Usuario", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Comissionado", NpgsqlDbType.Boolean));
                    com.Parameters.Add(new NpgsqlParameter("@Funcao", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Salario", NpgsqlDbType.Real));
                    com.Parameters.Add(new NpgsqlParameter("@UltimoPagamento", NpgsqlDbType.Date));
                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));
                    
                    com.Parameters["@Nome"].Value            = entidade.Nome;
                    com.Parameters["@Usuario"].Value         = entidade.Usuario;
                    com.Parameters["@Comissionado"].Value    = entidade.Comissionado;
                    com.Parameters["@Funcao"].Value          = entidade.Funcao;
                    com.Parameters["@Salario"].Value         = entidade.Salario;
                    com.Parameters["@UltimoPagamento"].Value = entidade.UltimoPagamento;
                    com.Parameters["@Codigo"].Value          = entidade.Codigo;

                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Funcionario, Util.Acao.UPDATE, com);

                        LogSistema.AdicionarEvento($"Funcionario de código '{entidade.Codigo}' atualizado com sucesso");
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

                LogSistema.AdicionarEvento($"Erro ao atualizar Funcionario: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public bool AtualizarSenha(Funcionario entidade, string senha, ulong usuario)
        {
            return AtualizarSenha(entidade.Codigo, senha, usuario);
        }

        public bool AtualizarSenha(ulong codigo, string senha, ulong usuario)
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
update funcionario
   set senha = @Senha
 where codigo = @Codigo;";
                    
                    com.Parameters.Add(new NpgsqlParameter("@Senha", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    senha = MPCConfigManager.GerarSenha(senha);

                    com.Parameters["@Senha"].Value  = senha;
                    com.Parameters["@Codigo"].Value = codigo;

                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Funcionario, Util.Acao.UPDATE, com);

                        LogSistema.AdicionarEvento($"Senha de Funcionario de código '{codigo}' atualizada com sucesso");
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

                LogSistema.AdicionarEvento($"Erro ao atualizar senha de Funcionario: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public Funcionario Buscar(ulong codigo)
        {
            Funcionario res = null;
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
select codigo, nome, usuario, senha, comissionado, funcao, salario, ultimo_pagamento
  from funcionario
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    com.Parameters["@Codigo"].Value = codigo;

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            res = new Funcionario
                            {
                                Codigo          = Convert.ToUInt64(reader["codigo"].ToString()),
                                Nome            = reader["nome"].ToString(),
                                Usuario         = reader["usuario"].ToString(),
                                Senha           = reader["senha"].ToString(),
                                Comissionado    = Convert.ToBoolean(reader["comissionado"].ToString()),
                                Funcao          = reader["funcao"].ToString(),
                                Salario         = Convert.ToSingle(reader["salario"].ToString()),
                                UltimoPagamento = Convert.ToDateTime(reader["ultimo_pagamento"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Funcionario: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }
        
        public Funcionario BuscarPorUsuario(string usuario)
        {
            Funcionario res = null;
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
select codigo, nome, usuario, senha, comissionado, funcao, salario, ultimo_pagamento
  from funcionario
 where usuario = @Usuario;";
                    
                    com.Parameters.Add(new NpgsqlParameter("@Usuario", NpgsqlDbType.Varchar));
                    
                    com.Parameters["@Usuario"].Value = usuario;

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            res = new Funcionario
                            {
                                Codigo          = Convert.ToUInt64(reader["codigo"].ToString()),
                                Nome            = reader["nome"].ToString(),
                                Usuario         = reader["usuario"].ToString(),
                                Senha           = reader["senha"].ToString(),
                                Comissionado    = Convert.ToBoolean(reader["comissionado"].ToString()),
                                Funcao          = reader["funcao"].ToString(),
                                Salario         = Convert.ToSingle(reader["salario"].ToString()),
                                UltimoPagamento = Convert.ToDateTime(reader["ultimo_pagamento"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Funcionario: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public List<Funcionario> BuscarPorNome(string nome)
        {
            List<Funcionario> res = null;
            try
            {
                NpgsqlConnection conexao = Util.ConexaoBanco.GetConnection();
                Util.ConexaoBanco.AbrirConexao();

                if (Util.ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                if (Util.ConexaoBanco.VerificarFuncaoBD("limpa_string") != 0)
                {
                    throw new Exception("A função limpa_string é necessária, mas não foi definida no banco");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
select codigo, nome, usuario, senha, comissionado, funcao, salario, ultimo_pagamento
  from funcionario
 where limpa_string(nome) ilike limpa_string(@Nome)
 order by nome asc;";

                    com.Parameters.Add(new NpgsqlParameter("@Nome", NpgsqlDbType.Varchar));

                    com.Parameters["@Nome"].Value = $"%{nome}%";

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = new List<Funcionario>();

                            while (reader.Read())
                            {
                                Funcionario linha = new Funcionario
                                {
                                    Codigo          = Convert.ToUInt64(reader["codigo"].ToString()),
                                    Nome            = reader["nome"].ToString(),
                                    Usuario         = reader["usuario"].ToString(),
                                    Senha           = reader["senha"].ToString(),
                                    Comissionado    = Convert.ToBoolean(reader["comissionado"].ToString()),
                                    Funcao          = reader["funcao"].ToString(),
                                    Salario         = Convert.ToSingle(reader["salario"].ToString()),
                                    UltimoPagamento = Convert.ToDateTime(reader["ultimo_pagamento"].ToString())
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

                LogSistema.AdicionarEvento($"Erro ao pesquisar por Funcionarios: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public Funcionario Inserir(Funcionario entidade, ulong usuario)
        {
            Funcionario res = null;
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
insert into funcionario (nome, usuario, senha, comissionado, funcao, salario, ultimo_pagamento)
values (@Nome, @Usuario, @Senha, @Comissionado, @Funcao, @Salario, @UltimoPagamento) returning codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Nome", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Usuario", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Senha", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Comissionado", NpgsqlDbType.Boolean));
                    com.Parameters.Add(new NpgsqlParameter("@Funcao", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Salario", NpgsqlDbType.Real));
                    com.Parameters.Add(new NpgsqlParameter("@UltimoPagamento", NpgsqlDbType.Date));

                    entidade.Senha = MPCConfigManager.GerarSenha(entidade.Senha);

                    com.Parameters["@Nome"].Value            = entidade.Nome;
                    com.Parameters["@Usuario"].Value         = entidade.Usuario;
                    com.Parameters["@Senha"].Value           = entidade.Senha;
                    com.Parameters["@Comissionado"].Value    = entidade.Comissionado;
                    com.Parameters["@Funcao"].Value          = entidade.Funcao;
                    com.Parameters["@Salario"].Value         = entidade.Salario;
                    com.Parameters["@UltimoPagamento"].Value = entidade.UltimoPagamento;

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

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Funcionario, Util.Acao.INSERT, com);

                        LogSistema.AdicionarEvento($"Funcionario de código '{codigo}' inserido com sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                res = null;

                LogSistema.AdicionarEvento($"Erro ao inserir novo Funcionario: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public List<Funcionario> ListarTodos()
        {
            List<Funcionario> res = null;
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
select codigo, nome, usuario, senha, comissionado, funcao, salario, ultimo_pagamento
  from funcionario;";

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = new List<Funcionario>();

                            while (reader.Read())
                            {
                                Funcionario linha = new Funcionario
                                {
                                    Codigo          = Convert.ToUInt64(reader["codigo"].ToString()),
                                    Nome            = reader["nome"].ToString(),
                                    Usuario         = reader["usuario"].ToString(),
                                    Senha           = reader["senha"].ToString(),
                                    Comissionado    = Convert.ToBoolean(reader["comissionado"].ToString()),
                                    Funcao          = reader["funcao"].ToString(),
                                    Salario         = Convert.ToSingle(reader["salario"].ToString()),
                                    UltimoPagamento = Convert.ToDateTime(reader["ultimo_pagamento"].ToString())
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

                LogSistema.AdicionarEvento($"Erro ao listar Funcionarios: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public bool Remover(Funcionario entidade, ulong usuario)
        {
            return Remover(entidade.Codigo, usuario);
        }

        public bool Remover(ulong codigo, ulong usuario)
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
delete from funcionario
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    com.Parameters["@Codigo"].Value = codigo;

                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;

                        Util.DAOLog.Inserir(usuario, Util.Tabela.Funcionario, Util.Acao.DELETE, com);

                        LogSistema.AdicionarEvento($"Funcionario de código '{codigo}' removido com sucesso");
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

                LogSistema.AdicionarEvento($"Erro ao remover Funcionario: {ex.Message}");
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
