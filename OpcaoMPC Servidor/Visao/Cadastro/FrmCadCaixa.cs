using OpcaoMPCServidor.Controle;
using System;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Cadastro
{
    public partial class FrmNovoCaixa : Form
    {
        public bool Valido { get; private set; } = false;

        public FrmNovoCaixa()
        {
            InitializeComponent();
        }

        private void BtnContinuarClick(object sender, EventArgs e)
        {
            CtrlCaixaS ctrlCaixa = new CtrlCaixaS();

            float valor = Convert.ToSingle(numCaixa.Value);

            Valido = ctrlCaixa.PrimeiroCaixa(valor);

            if (!Valido)
            {
                MessageBox.Show(
                    "Ocorreu algum erro, tente novamente",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }
    }
}
