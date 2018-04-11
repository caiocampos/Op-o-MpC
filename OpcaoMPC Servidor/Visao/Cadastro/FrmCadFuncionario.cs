using Controle;
using Modelo;
using OpcaoMPCServidor.Controle;
using OpcaoMPCServidor.Visao.Validacao;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Cadastro
{
    public partial class FrmCadFuncionario : Form
    {
        public const int Novo = 0;
        public const int Atualizacao = 1;
        public const int Primeiro = 2;
        public const int Proprio = 3;

        private int modo = Novo;
        private Funcionario funci = null;
        public bool Valido { get; private set; } = false;

        public FrmCadFuncionario()
        {
            InitializeComponent();

            MudarVisibilidade();

            MudarMsgErro(string.Empty);
        }
        
        public FrmCadFuncionario(int modo)
        {
            InitializeComponent();

            if (modo == 1)
            {
                Close();

                throw new Exception("Tela de cadastro de funcionários aberta de forma incorreta");
            }
            this.modo = modo;

            MudarVisibilidade();

            MudarMsgErro(string.Empty);
        }

        public FrmCadFuncionario(Funcionario funci)
        {
            InitializeComponent();

            modo = funci.Codigo == ControleDeUsuario.Id
                ? Proprio : Atualizacao;

            this.funci = funci;

            MudarVisibilidade();

            MudarMsgErro(string.Empty);

            PreencherCampos();
        }

        private void MudarVisibilidade()
        {
            if (modo == Atualizacao)
            {
                txtSenha.Visible = false;
                lblSenha.Visible = false;
                txtConf.Visible = false;
                lblConf.Visible = false;
                txtAtual.Visible = false;
                lblAtual.Visible = false;
                btnApagar.Visible = true;
                chbSenha.Visible = false;
            }
            else
            {
                if (modo == Proprio)
                {
                    txtSenha.Visible = false;
                    lblSenha.Visible = false;
                    txtConf.Visible = false;
                    lblConf.Visible = false;
                    chbSenha.Visible = true;
                }
                else
                {
                    txtSenha.Visible = true;
                    lblSenha.Visible = true;
                    txtConf.Visible = true;
                    lblConf.Visible = true;
                    chbSenha.Visible = false;
                }
                txtAtual.Visible = false;
                lblAtual.Visible = false;
                btnApagar.Visible = false;
            }
        }

        private void PreencherCampos()
        {
            txtNome.Text = funci.Nome;
            txtUsuario.Text = funci.Usuario;
            chbComissionado.Checked = funci.Comissionado;
            txtFuncao.Text = funci.Funcao;
            numSalario.Value = Convert.ToDecimal(funci.Salario);
        }

        private void BtnContinuarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtFuncao.Text))
            {
                MudarMsgErro("Erro: preencha todos os campos com asterisco");
                GestoNegativo();
                return;
            }
            
            if (modo == Proprio)
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    modo = Atualizacao;
                }
            }

            if (modo != Atualizacao)
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MudarMsgErro("Erro: a senha não pode ficar vazia");
                    GestoNegativo();
                    return;
                }

                if (txtSenha.Text != txtConf.Text)
                {
                    MudarMsgErro("Erro: a senha não pode ser diferente da confirmação");
                    GestoNegativo();
                    return;
                }

                if (modo == Proprio)
                {
                    if (string.IsNullOrWhiteSpace(txtAtual.Text))
                    {
                        MudarMsgErro("Erro: a senha atual não pode ficar vazia");
                        GestoNegativo();
                        return;
                    }
                }
                else
                {
                    funci = new Funcionario();
                }

                funci.Senha = txtSenha.Text;
            }
            CtrlFuncionarioS ctrlFuncionario = new CtrlFuncionarioS();
            CtrlUsuarioS ctrlUsuario = new CtrlUsuarioS();
            ulong id;

            funci.Nome = txtNome.Text;
            funci.Usuario = txtUsuario.Text;
            funci.Comissionado = chbComissionado.Checked;
            funci.Funcao = txtFuncao.Text;
            funci.Salario = Convert.ToSingle(numSalario.Value);

            if (modo == Primeiro)
            {
                id = DAL.Util.Usuario.SISTEMA;
            }
            else
            {
                id = ControleDeUsuario.Id;

                FrmAutenticacaoSuper aSuper = new FrmAutenticacaoSuper();

                aSuper.ShowDialog();

                if (!aSuper.Valido)
                {
                    MudarMsgErro("Operação cancelada");

                    aSuper.Dispose();

                    return;
                }
                aSuper.Dispose();
            }
            
            if (modo != Atualizacao)
            {
                funci.Senha = txtSenha.Text;

                if (modo == Proprio)
                {
                    Valido = ctrlUsuario.AtualizarSenha(funci.Usuario, txtAtual.Text, funci.Senha);

                    if (Valido)
                    {
                        Valido = ctrlFuncionario.Atualizar(funci, id);
                    }
                }
                else
                {
                    funci = ctrlFuncionario.Inserir(funci, id);

                    Valido = funci == null
                        ? false : true;
                }
            }
            else
            {
                Valido = ctrlFuncionario.Atualizar(funci, id);
            }

            if (Valido)
            {
                if(funci.Codigo == ControleDeUsuario.Id)
                {
                    ControleDeUsuario.AtualizarUsuario(funci.Usuario);
                }
                Close();
            }
            else
            {
                MudarMsgErro("Erro: O sistema não pôde concluir a operação");
                GestoNegativo();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            if (modo == Primeiro)
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

        private void BtnApagarClick(object sender, EventArgs e)
        {
            ulong id = ControleDeUsuario.Id;
            string msg = string.Empty;

            if (id == funci.Codigo)
            {
                msg = "Você não pode apagar seu próprio usuário";
            }
            else
            {
                CtrlFuncionarioS ctrlFuncionario = new CtrlFuncionarioS();

                FrmAutenticacaoSuper aSuper = new FrmAutenticacaoSuper();

                aSuper.ShowDialog();

                if (!aSuper.Valido)
                {
                    aSuper.Dispose();

                    return;
                }
                aSuper.Dispose();

                bool res = ctrlFuncionario.Remover(funci, id);

                msg = res
                    ? "Funcionário excluído com sucesso" : "A operação não pôde ser concluída";
            }
            MessageBox.Show(
                msg,
                "Confirmação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private void ChbSenhaCheckedChanged(object sender, EventArgs e)
        {
            bool estado = chbSenha.Checked;

            txtSenha.Visible = estado;
            lblSenha.Visible = estado;
            txtConf.Visible = estado;
            lblConf.Visible = estado;
            txtAtual.Visible = estado;
            lblAtual.Visible = estado;
        }

        private void BtnPagamentoClick(object sender, EventArgs e)
        {

        }
    }
}
