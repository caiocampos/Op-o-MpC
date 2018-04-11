using Controle;
using OpcaoMPCServidor.Controle;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Validacao
{
    public partial class FrmTesteUsuario : Form
    {
        public bool AcessoPermitido { get; private set; } = false;

        public FrmTesteUsuario()
        {
            InitializeComponent();
            
            string usuario = ControleDeUsuario.NomeUsuario;

            txtUsuario.Text = string.IsNullOrWhiteSpace(usuario)
                ? MPCConfigManager.GetUsuarioPadrao() : usuario;
        }

        public FrmTesteUsuario(string usuario)
        {
            InitializeComponent();

            txtUsuario.Text = usuario;
            txtUsuario.Enabled = false;
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnContinuarClick(object sender, EventArgs e)
        {
            lblMensagem.Hide();

            AcessoPermitido = ControleDeUsuario.VerificarSenha(new CtrlUsuarioS(), txtUsuario.Text, txtSenha.Text);

            if (!AcessoPermitido)
            {
                lblMensagem.Show();

                for (int i = 0; i < 3; i++)
                {
                    #region Movimento para a esquerda

                    Thread.Sleep(35);
                    Left += 1;
                    Thread.Sleep(10);
                    Left += 1;
                    Thread.Sleep(10);
                    Left += 1;
                    Thread.Sleep(10);
                    Left += 1;
                    Thread.Sleep(10);
                    Left += 1;

                    #endregion

                    #region Movimento para a direita

                    Thread.Sleep(35);
                    Left -= 1;
                    Thread.Sleep(10);
                    Left -= 1;
                    Thread.Sleep(10);
                    Left -= 1;
                    Thread.Sleep(10);
                    Left -= 1;
                    Thread.Sleep(10);
                    Left -= 1;

                    #endregion
                }
            }
            else
            {
                MPCConfigManager.SetUsuarioPadrao(txtUsuario.Text);
                Close();
            }
        }

        public void AdcionarEventoContinuar(EventHandler ev)
        {
            btnContinuar.Click += ev;
        }
    }
}
