using RecantoDosPapagaios.Business;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios
{
    public partial class frmTelaDeLogin : Form
    {
        private readonly LoginBusiness _loginBusiness;

        private readonly FuncionarioBusiness _funcionarioBusiness;


        public frmTelaDeLogin()
        {
            InitializeComponent();

            _loginBusiness = new LoginBusiness();
            _funcionarioBusiness = new FuncionarioBusiness();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            frmEsqueciSenha fEsqueciSenha = new frmEsqueciSenha();
            fEsqueciSenha.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuarioEmail.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Informe o seu usuário ou seu e-mail cadastrado.", "Login");
                    return;
                }
                if (txtSenha.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Informe sua senha.", "Login");
                    return;
                }

                var retorno = _loginBusiness.FazerLogin(txtUsuarioEmail.Text, txtSenha.Text);

                if (retorno.Retorno.StatusCode == 200)
                {
                    var funcionario = _funcionarioBusiness.Obter(retorno.Cpf);

                    if (funcionario != null)
                    {
                        frmTelaPrincipal fTelaPrincipal = new frmTelaPrincipal(funcionario);

                        fTelaPrincipal.IdFuncionario = retorno.IdUsuario;
                        fTelaPrincipal.NomeDeUsuario = retorno.NomeDeUsuario;
                        fTelaPrincipal.Senha = txtSenha.Text;
                        fTelaPrincipal.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao processar o usuário.", "Login");
                    }
                }
                else
                {
                    MessageBox.Show(retorno.Retorno.Mensagem, "Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Login"
                );
            }
        }

        private void btnHideShowPasswordLog_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                btnHideShowPasswordLog.BackgroundImage = Properties.Resources.EyeOpenedWhite;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                btnHideShowPasswordLog.BackgroundImage = Properties.Resources.EyeHidenWhite;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuarioEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnEntrar_Click(btnEntrar, new EventArgs());
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnEntrar_Click(btnEntrar, new EventArgs());
            }
        }
                
    }
}
