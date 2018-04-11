using Controle;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Data.Common;

namespace OpcaoMPCServidor.DAL.Util
{
    public static class DAOLog
    {
        public static bool Inserir(ulong usuario, string tabela, string acao, DbCommand codigoExecutado)
        {
            bool res = true;
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
insert into log (usuario, tabela, acao, codigo_executado)
values (@Usuario, @Tabela, @Acao, @CodigoExecutado);";

                    com.Parameters.Add(new NpgsqlParameter("@Usuario", NpgsqlDbType.Bigint));
                    com.Parameters.Add(new NpgsqlParameter("@Tabela", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@Acao", NpgsqlDbType.Varchar));
                    com.Parameters.Add(new NpgsqlParameter("@CodigoExecutado", NpgsqlDbType.Varchar));

                    com.Parameters["@Usuario"].Value = usuario;
                    com.Parameters["@Tabela"].Value = tabela;
                    com.Parameters["@Acao"].Value = acao;
                    com.Parameters["@CodigoExecutado"].Value = GetGeneratedQuery(codigoExecutado);

                    int retorno = com.ExecuteNonQuery();

                    if (retorno == 0)
                    {
                        throw new Exception("Não foi possível fazer a inclusão");
                    }
                }
            }
            catch (Exception ex)
            {
                res = false;

                LogSistema.AdicionarEvento($"Erro ao adicionar ao log: {ex.Message}");
            }
            finally
            {
                Util.ConexaoBanco.FecharConexao();
            }
            return res;
        }

        public static string GetGeneratedQuery(DbCommand dbCommand)
        {
            string query = dbCommand.CommandText;

            foreach (DbParameter parameter in dbCommand.Parameters)
            {
                query = query.Replace(parameter.ParameterName, parameter.Value.ToString());
            }
            return query;
        }
    }
}
