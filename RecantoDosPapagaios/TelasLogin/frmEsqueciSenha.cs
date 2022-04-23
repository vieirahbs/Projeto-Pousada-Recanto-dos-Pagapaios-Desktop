using RecantoDosPapagaios.Business;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios
{
    public partial class frmEsqueciSenha : Form
    {
        private readonly LoginBusiness _loginBusiness;

        public frmEsqueciSenha()
        {
            InitializeComponent();

            _loginBusiness = new LoginBusiness();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaDeLogin fTelaDeLogin = new frmTelaDeLogin();
            this.Close();
            fTelaDeLogin.Show();
        }

        private void btnEncontrarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPF.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Digite seu CPF.", "Recuperação de senha");
                    this.Focus();
                    return;
                }

                var conta = _loginBusiness.EncontrarConta(txtCPF.Text);

                if (!string.IsNullOrEmpty(conta.Cpf))
                {
                    frmTelaPerguntaDeSeguranca fTelaPerguntaDeSeguranca = new frmTelaPerguntaDeSeguranca(conta);
                    this.Close();
                    fTelaPerguntaDeSeguranca.Show();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado um usuário para o CPF " + txtCPF.Text + ".");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Recuperação de senha"
                );
            }
        }
    }
}
