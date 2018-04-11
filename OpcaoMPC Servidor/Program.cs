using Controle;
using OpcaoMPCServidor.Controle;
using OpcaoMPCServidor.Visao;
using OpcaoMPCServidor.Visao.Cadastro;
using OpcaoMPCServidor.Visao.Validacao;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OpcaoMPCServidor
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string nomeProcesso = Process.GetCurrentProcess().ProcessName;
            Process[] processos = Process.GetProcessesByName(nomeProcesso);

            if (processos.Length > 1)
            {
                MessageBox.Show(
                    "Este programa já está em execução.",
                    "Programa em execução",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Application.Exit();
            }
            else
            {
                LogSistema.AdicionarEvento("Sistema iniciado");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                VerificarPrimeiraExecucao();

                Application.Run(new FrmInicial());
            }
        }

        public static void VerificarPrimeiraExecucao()
        {
            if (!CtrlSuper.VerificarSuper())
            {
                CriarSuper();
                CriarFuncionario();
            }

            CtrlCaixaS ctrlCaixa = new CtrlCaixaS();

            if (!ctrlCaixa.IniciarCaixa())
            {
                CriarCaixa(ctrlCaixa);
            }
        }

        public static void CriarSuper()
        {
            string msgBoasVindas =
                "Esta é a primeira execução deste programa!" + Environment.NewLine + Environment.NewLine +
                "Por favor crie a senha do super-usuário." + Environment.NewLine +
                "A senha de super-usuário libera ações que necessitam de maior autoridade, " + Environment.NewLine +
                "não perca ela e forneça ela para o mínimo de pessoas possível!";
            MessageBox.Show(
                msgBoasVindas, 
                "Bem-Vindo", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.None);

            FrmAutenticacaoSuper aSuper = new FrmAutenticacaoSuper(FrmAutenticacaoSuper.Criacao);

            while (!aSuper.Valido)
            {
                aSuper.ShowDialog();
            }

            aSuper.Dispose();
        }

        public static void CriarCaixa(ICtrlCaixa ctrlCaixa)
        {
            MessageBox.Show(
                "Por favor entre com o caixa atual da loja.", 
                "Primeiro caixa", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.None);

            FrmNovoCaixa nCaixa = new FrmNovoCaixa();

            while (!nCaixa.Valido)
            {
                nCaixa.ShowDialog();
            }

            nCaixa.Dispose();
        }
        
        public static void CriarFuncionario()
        {
            MessageBox.Show(
                "Por favor entre com seus dados.", 
                "Primeiro funcionário", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.None);

            FrmCadFuncionario cadFunc = new FrmCadFuncionario(FrmCadFuncionario.Primeiro);

            while (!cadFunc.Valido)
            {
                cadFunc.ShowDialog();
            }

            cadFunc.Dispose();
        }
    }
}
