using System;

namespace Controle
{
    public static class ControleDeUsuario
    {
        public static UInt64 Id { get; private set; } = 0;

        public static string NomeUsuario { get; private set; } = string.Empty;

        public static bool VerificarSenha(ICtrlUsuario ctu, string usuario, string senha, bool salvarUsr = true)
        {
            ulong res = ctu.VerificarSenha(usuario, senha);

            if (res == 0)
            {
                return false;
            }

            if (salvarUsr)
            {
                Id = res;
                NomeUsuario = usuario;
            }
            LogSistema.AdicionarEvento($"Acesso bem sucedido com o usuaráio: {usuario}");

            return true;
        }

        public static bool AtualizarSenha(ICtrlUsuario ctu, string usuario, string senhaAnt, string senhaNov)
        {
            bool verfSenha = VerificarSenha(ctu, usuario, senhaAnt, false);

            if (!verfSenha)
            {
                return false;
            }
            bool atualizou = ctu.AtualizarSenha(usuario, senhaAnt, senhaNov);

            return atualizou;
        }

        public static void AtualizarUsuario(string usuario)
        {
            if (!string.IsNullOrWhiteSpace(usuario))
            {
                NomeUsuario = usuario;
            }
        }
    }
}
