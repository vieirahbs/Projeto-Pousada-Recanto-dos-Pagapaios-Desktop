using RecantoDosPapagaios.Entities;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios
{
    public partial class frmTelaPerguntaDeSeguranca : Form
    {
        private readonly PerguntaDeSeguranca _pergunta; 

        public frmTelaPerguntaDeSeguranca(PerguntaDeSeguranca pergunta)
        {
            InitializeComponent();

            _pergunta = pergunta;

            labelPergunta.Text = _pergunta.PerguntaSeguranca;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEsqueciSenha fEsqueciSenha = new frmEsqueciSenha();
            this.Close();
            fEsqueciSenha.Show();
        }

        private void btnProximoPasso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResposta.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Você precisa responder a pergunta de segurança.", 
                        "Recuperação de senha");
                    txtResposta.Focus();
                    return;
                }

                if (_pergunta.RespostaSeguranca == txtResposta.Text.Trim())
                {
                    frmTelaDefinicaoSenha fTelaDefiniacoSenha = new frmTelaDefinicaoSenha(_pergunta);
                    this.Close();
                    fTelaDefiniacoSenha.Show();
                }
                else
                {
                    MessageBox.Show("A resposta informada não é igual a ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível atender sua solicitação. Tente novamente.",
                    "Recuperação de senha");
            }
        }
    }
}
