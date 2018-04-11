using Controle;
using Npgsql;
using OpcaoMPCServidor.Controle;
using System;
using System.Data;
using System.Data.Common;

namespace OpcaoMPCServidor.DAL.Util
{
    public static class ConexaoBanco
    {
        private static NpgsqlConnection con;
        
        private static void VerificarConexao()
        {
            if (con == null)
            {
                try
                {
                    con = new NpgsqlConnection(MPCConfigManager.GetDBOpcaoMPC());

                    LogSistema.AdicionarEvento("Banco de dados conectado");
                }
                catch (Exception ex)
                {
                    LogSistema.AdicionarEvento($"Erro no acesso ao banco de dados: {ex.Message}");
                }
            }
        }

        public static void AbrirConexao()
        {
            VerificarConexao();

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    LogSistema.AdicionarEvento($"Erro na abertura da conexão com o banco de dados: {ex.Message}");
                }
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            VerificarConexao();

            return con;
        }
        
        public static void FecharConexao()
        {
            VerificarConexao();

            if (con.State == ConnectionState.Open)
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    LogSistema.AdicionarEvento($"Erro no fechamento da conexão com o banco de dados: {ex.Message}");
                }
            }
        }

        public static int SetDefaultSchema()
        {
            int res = 0;
            try
            {
                res = SetSchema(MPCConfigManager.GetEsquemaPadrao());
            }
            catch (Exception ex)
            {
                res = -5;

                LogSistema.AdicionarEvento($"Erro genérico na definição do esquema do banco de dados: {ex.Message}");
            }
            return res;
        }

        public static int SetSchema(string schema)
        {
            int res = 0;

            VerificarConexao();

            if (con.State != ConnectionState.Open)
            {
                res = -1;

                return res;
            }

            try
            {
                using (NpgsqlCommand comando = con.CreateCommand())
                {
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = $"set search_path to {schema};";
                        comando.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                res = -2;

                LogSistema.AdicionarEvento($"Erro na definição do esquema do banco de dados: {ex.Message}");
            }
            catch (DbException ex)
            {
                res = -3;

                LogSistema.AdicionarEvento($"Erro na definição do esquema do banco de dados: {ex.Message}");
            }
            catch (Exception ex)
            {
                res = -4;

                LogSistema.AdicionarEvento($"Erro genérico na definição do esquema do banco de dados: {ex.Message}");
            }
            return res;
        }

        public static int VerificarFuncaoBD(string nome)
        {
            int res = 0;

            VerificarConexao();

            if (con.State != ConnectionState.Open)
            {
                res = -1;

                return res;
            }

            try
            {
                using (NpgsqlCommand comando = con.CreateCommand())
                {
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = $"select '{nome}'::regproc;";

                    using (NpgsqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            res = 0;
                        }
                        else
                        {
                            res = -2;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                res = -3;

                LogSistema.AdicionarEvento($"Erro ao verificar a existência de função: {ex.Message}");
            }
            catch (DbException ex)
            {
                res = -4;

                LogSistema.AdicionarEvento($"Erro ao verificar a existência de função: {ex.Message}");
            }
            catch (Exception ex)
            {
                res = -5;

                LogSistema.AdicionarEvento($"Erro genérico ao verificar a existência de função: {ex.Message}");
            }
            return res;
        }
    }
}
