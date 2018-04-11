using OpcaoMPCServidor.DAL.Util;

namespace OpcaoMPCServidor.Controle
{
    public static class CtrlSuper
    {
        public static bool VerificarSuper()
        {
            string senha = DAOSuper.Buscar();
            
            if (senha != null)
            {
                if (senha != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Atualizar(string senha)
        {
            return string.IsNullOrWhiteSpace(senha) 
                ? false : DAOSuper.Atualizar(senha);
        }

        public static bool Inserir(string senha)
        {
            return string.IsNullOrWhiteSpace(senha) 
                ? false : DAOSuper.Inserir(senha);
        }
        
        public static bool VerificarSenha(string senha)
        {
            string senhaBanco = DAOSuper.Buscar();

            return senhaBanco == MPCConfigManager.GerarSenha(senha);
        }
    }
}
