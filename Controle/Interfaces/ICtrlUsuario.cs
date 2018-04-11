namespace Controle
{
    public interface ICtrlUsuario
    {
        ulong VerificarSenha(string usuario, string senha);
        bool AtualizarSenha(string usuario, string senhaAnt, string SenhaNov);
    }
}
