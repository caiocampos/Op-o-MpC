using Controle;
using Npgsql;
using NpgsqlTypes;
using OpcaoMPCServidor.Controle;
using System;
using System.Data;

namespace OpcaoMPCServidor.DAL.Util
{
    public static class DAOSuper
    {
        private const ulong codigo = 1;

        public static bool Atualizar(string senha)
        {
            bool res = false;
            try
            {
                NpgsqlConnection conexao = ConexaoBanco.GetConnection();
                ConexaoBanco.AbrirConexao();

                if (ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
update super_usuario
   set senha = @Senha
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Senha", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Smallint));

                    senha = MPCConfigManager.GerarSenha(senha);

                    com.Parameters["@Senha"].Value  = senha;
                    com.Parameters["@Codigo"].Value = codigo;

                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public static string Buscar()
        {
            string res = null;
            try
            {
                NpgsqlConnection conexao = ConexaoBanco.GetConnection();
                ConexaoBanco.AbrirConexao();

                if (ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
select senha
  from super_usuario
 where codigo = @Codigo;";

                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Bigint));

                    com.Parameters["@Codigo"].Value = codigo;

                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            
                            res = reader["senha"].ToString();
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
                ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public static bool Inserir(string senha)
        {
            bool res = false;
            try
            {
                NpgsqlConnection conexao = ConexaoBanco.GetConnection();
                ConexaoBanco.AbrirConexao();

                if (ConexaoBanco.SetDefaultSchema() != 0)
                {
                    throw new Exception("Erro de acesso ao banco, erro na definição definição do esquema do banco de dados");
                }

                using (NpgsqlCommand com = conexao.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"
insert into super_usuario (codigo, senha)
values (@Codigo, @Senha);";

                    com.Parameters.Add(new NpgsqlParameter("@Codigo", NpgsqlDbType.Smallint));
                    com.Parameters.Add(new NpgsqlParameter("@Senha", NpgsqlDbType.Varchar));

                    senha = MPCConfigManager.GerarSenha(senha);

                    com.Parameters["@Codigo"].Value = codigo;
                    com.Parameters["@Senha"].Value  = senha;
                    
                    if (com.ExecuteNonQuery() > 0)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                ConexaoBanco.FecharConexao();
            }
            return res;
        }
    }
}
