using Controle;
using Modelo;
using OpcaoMPCServidor.DAL;

namespace OpcaoMPCServidor.Controle
{
    public class CtrlUsuarioS : ICtrlUsuario
    {
        private static DAOFuncionario daoFunc = new DAOFuncionario();

        public bool AtualizarSenha(string usuario, string senhaAnt, string SenhaNov)
        {
            Funcionario f = daoFunc.BuscarPorUsuario(usuario);

            if (f == null)
            {
                return false;
            }
            return f.Senha != MPCConfigManager.GerarSenha(senhaAnt) 
                ? false : daoFunc.AtualizarSenha(f, SenhaNov, f.Codigo);
        }

        public ulong VerificarSenha(string usuario, string senha)
        {
            Funcionario func = daoFunc.BuscarPorUsuario(usuario);

            if (func == null)
            {
                return 0;
            }
            return func.Senha != MPCConfigManager.GerarSenha(senha) 
                ? 0 : func.Codigo;
        }
    }
}
