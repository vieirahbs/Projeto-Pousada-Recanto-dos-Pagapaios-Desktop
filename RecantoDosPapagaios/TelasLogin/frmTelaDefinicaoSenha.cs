using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios
{
    public partial class frmTelaDefinicaoSenha : Form
    {
        private readonly LoginBusiness _loginBusiness;
        
        private readonly PerguntaDeSeguranca _pergunta;

        public frmTelaDefinicaoSenha(PerguntaDeSeguranca pergunta)
        {
            InitializeComponent();

            _pergunta = pergunta;

            _loginBusiness = new LoginBusiness();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPerguntaDeSeguranca fTelaPerguntaDeSeguranca = new frmTelaPerguntaDeSeguranca(_pergunta);
            this.Close();
            fTelaPerguntaDeSeguranca.Show();
        }

        private void btnDefinirNovaSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNovaSenha.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Informe sua nova senha.", "Recuperação de senha");
                    txtNovaSenha.Focus();
                    return;
                }
                else if (txtRepetirSenha.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Preencha o campo 'Repetir senha'.", "Recuperação de senha");
                    txtRepetirSenha.Focus();
                    return;
                }
                else if (txtNovaSenha.Text != txtRepetirSenha.Text)
                {
                    MessageBox.Show("As senhas dos campos 'Nova senha' e 'Repetir senha'" +
                        "precisam ser iguais.", "Recuperação de senha");
                    txtRepetirSenha.Focus();
                    return;
                }

                var novaSenha = new DefinirNovaSenha
                {
                    Cpf = _pergunta.Cpf,
                    NovaSenha = txtNovaSenha.Text,
                    RepeticaoSenha = txtRepetirSenha.Text
                };

                var resultado = _loginBusiness.DefinirNovaSenha(novaSenha);

                if (resultado.StatusCode == 200)
                {
                    MessageBox.Show(resultado.Mensagem, "Recuperação de senha");

                    txtNovaSenha.Clear();
                    txtRepetirSenha.Clear();
                }
                else
                {
                    MessageBox.Show(resultado.Mensagem, "Recuperação de senha");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Recuperação de senha"
                );
            }

            this.Close();
        }

        private void btnHideShowPassword1_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.UseSystemPasswordChar == true)
            {
                btnHideShowPassword1.BackgroundImage = Properties.Resources.EyeOpened;
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                btnHideShowPassword1.BackgroundImage = Properties.Resources.EyeHiden;
                txtNovaSenha.UseSystemPasswordChar = true; 
            }
        }

        private void btnHideShowPassword2_Click(object sender, EventArgs e)
        {
            if (txtRepetirSenha.UseSystemPasswordChar == true)
            {
                btnHideShowPassword2.BackgroundImage = Properties.Resources.EyeOpened;
                txtRepetirSenha.UseSystemPasswordChar = false;
            }
            else
            {
                btnHideShowPassword2.BackgroundImage = Properties.Resources.EyeHiden;
                txtRepetirSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
