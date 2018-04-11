using Controle;
using OpcaoMPCServidor.Controle;
using OpcaoMPCServidor.Visao.Validacao;
using System;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
            
            lstLog.DataSource = LogSistema.GetEventos();
        }

        public void EscreverLogEstoque(String mensagem)
        {
            lstLogEstoque.Items.Add(mensagem);
        }

        private void Mostrar()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void Ocutar()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void NotiOMPCDoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Mostrar();
                return;
            }

            if (WindowState == FormWindowState.Normal)
            {
                Ocutar();
                return;
            }
        }

        private void MenuBandejaSairClick(object sender, EventArgs e)
        {
            notiOMPC.Visible = false;
            Application.Exit();
        }

        private void MitemMenuBandejaMostrarClick(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void BtnGerSisClick(object sender, EventArgs e)
        {
            if (CtrlBloqueioTela.Gerencia == null)
            {
                FrmTesteUsuario tstU = new FrmTesteUsuario();

                while (!tstU.AcessoPermitido)
                {
                    tstU.ShowDialog();
                }
                tstU.Dispose();

                CtrlBloqueioTela.Gerencia = new FrmGerencia();

                CtrlBloqueioTela.Gerencia.Show();
                CtrlBloqueioTela.Gerencia.Focus();

                CtrlBloqueioTela.Gerencia.FormClosed += delegate { CtrlBloqueioTela.Gerencia = null; };
            }
            else
            {
                CtrlBloqueioTela.Gerencia.Show();
                CtrlBloqueioTela.Gerencia.Focus();
            }
        }

        private void FrmInicialLoad(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void FrmInicialFormClosing(object sender, FormClosingEventArgs e)
        {
            // Retornar
            // e.Cancel = true;
            // Ocutar();
        }
    }
}
