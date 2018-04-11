namespace OpcaoMPCServidor.Controle
{
    public static class CtrlBloqueioTela
    {
        public static Visao.FrmGerencia Gerencia { get; set; } = null;
        
        public static void BloquearTela()
        {
            if (Gerencia != null)
            {
                Gerencia.BloquearTela();
            }
        }
        public static void DesloquearTela()
        {
            if (Gerencia != null)
            {
                Gerencia.DesbloquearTela();
            }
        }
    }
}
