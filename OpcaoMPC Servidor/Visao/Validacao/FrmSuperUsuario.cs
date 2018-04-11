using OpcaoMPCServidor.Controle;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Validacao
{
    public partial class FrmAutenticacaoSuper : Form
    {
        public const int Validacao = 0;
        public const int Atualizacao = 1;
        public const int Criacao = 2;

        private int modo = Validacao;
        public bool Valido { get; private set; } = false;

        public FrmAutenticacaoSuper()
        {
            InitializeComponent();

            MudarVisibilidade();

            MudarMsgErro(string.Empty);
        }

        public FrmAutenticacaoSuper(int modo)
        {
            InitializeComponent();

            this.modo = modo;

            MudarVisibilidade();

            switch (modo)
            {
                case Validacao:
                    lblInformativo.Text = "Por favor entre com a senha de super-usuário para continuar:";
                    break;
                case Atualizacao:
                    lblInformativo.Text = "Por favor entre com todos os dados para atualizar o super-usuário:";
                    break;
                case Criacao:
                    lblInformativo.Text = "Por favor entre com a senha e confirmação para continuar:";
                    break;
            }

            MudarMsgErro(string.Empty);
        }

        private void MudarVisibilidade()
        {
            if (modo == Validacao)
            {
                txtAtual.Visible = false;
                lblAtual.Visible = false;
                txtConf.Visible = false;
                lblConf.Visible = false;
            }
            else if (modo == Atualizacao)
            {
                txtAtual.Visible = true;
                lblAtual.Visible = true;
                txtConf.Visible = true;
                lblConf.Visible = true;
            }
            else
            {
                txtAtual.Visible = false;
                lblAtual.Visible = false;
                txtConf.Visible = true;
                lblConf.Visible = true;
            }
        }

        private void BtnContinuarClick(object sender, EventArgs e)
        {
            MudarMsgErro(string.Empty);

            string msg = string.Empty;

            if (modo == Validacao)
            {
                Valido = CtrlSuper.VerificarSenha(txtSenha.Text);
                
                msg = "Erro: a senha não está correta";
            }
            else if (modo == Atualizacao)
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    Valido = false;

                    msg = "Erro: a senha não pode ficar em branco";
                }
                else
                {
                    if (txtConf.Text != txtSenha.Text)
                    {
                        Valido = false;

                        msg = "Erro: a senha não pode ser diferente da confirmação";
                    }
                    else
                    {
                        if (!CtrlSuper.VerificarSenha(txtAtual.Text))
                        {
                            Valido = false;

                            msg = "Erro: a senha não está correta";
                        }
                        else
                        {
                            Valido = CtrlSuper.Atualizar(txtSenha.Text);

                            msg = "Erro: O sistema não pôde concluir a operação";
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    Valido = false;

                    msg = "Erro: a senha não pode ficar em branco";
                }
                else
                {
                    if (txtConf.Text != txtSenha.Text)
                    {
                        Valido = false;

                        msg = "Erro: a senha não pode ser diferente da confirmação";
                    }
                    else
                    {
                        Valido = CtrlSuper.Inserir(txtSenha.Text);

                        msg = "Erro: O sistema não pôde concluir a operação";
                    }
                }
            }
            
            if (!Valido)
            {
                MudarMsgErro(msg);
                GestoNegativo();
            }
            else
            {
                Close();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            if (modo == Criacao)
            {
                MudarMsgErro("Erro: esta etapa não pode ser pulada");
                GestoNegativo();
            }
            else
            {
                Valido = false;

                Close();
            }
        }

        private void MudarMsgErro(string msg)
        {
            lblMensagem.Text = msg;
        }

        private void GestoNegativo()
        {
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
    }
}
