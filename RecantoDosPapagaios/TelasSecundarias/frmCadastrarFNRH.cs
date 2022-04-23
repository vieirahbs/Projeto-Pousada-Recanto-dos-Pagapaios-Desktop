using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmCadastrarFNRH : Form
    {
        private readonly FNRHBusiness _fnrhBusiness;

        public frmCadastrarFNRH()
        {
            _fnrhBusiness = new FNRHBusiness();
        }

        public Hospede Hospede;

        public frmCadastrarFNRH(Hospede hospede)
        {
            InitializeComponent();

            _fnrhBusiness = new FNRHBusiness();

            Hospede = hospede;
        }

        private void frmCadastrarFNRH_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
        }

        private void btnSalvarFNRH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProfissao.Text.Trim().Equals(string.Empty) ||
                                txtNacionalidade.Text.Trim().Equals(string.Empty) ||
                                cmbSexo.SelectedIndex.Equals(-1) ||
                                txtIdentidade.Text.Trim().Equals(string.Empty) ||
                                txtUltimoDestino.Text.Trim().Equals(string.Empty) ||
                                txtProximoDestino.Text.Trim().Equals(string.Empty) ||
                                txtMotivoViagem.Text.Trim().Equals(string.Empty) ||
                                txtMeioDeTransporte.Text.Trim().Equals(string.Empty) ||
                                txtPlacaDoCarro.Text.Trim().Equals(string.Empty) ||
                                txtNumeroAcompanhantes.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("É necessário preencher todos os campos", "Cadastro de FNRH");
                }
                else
                {
                    var fnrh = new FNRH
                    {
                        Profissao = txtProfissao.Text,
                        Nacionalidade = txtNacionalidade.Text,
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        Rg = txtIdentidade.Text,
                        UltimoDestino = txtUltimoDestino.Text,
                        ProximoDestino = txtProximoDestino.Text,
                        MotivoViagem = txtMotivoViagem.Text,
                        MeioDeTransporte = txtMeioDeTransporte.Text,
                        PlacaAutomovel = txtPlacaDoCarro.Text,
                        NumAcompanhantes = int.Parse(txtNumeroAcompanhantes.Text)
                    };

                    var post = _fnrhBusiness.Inserir(fnrh, int.Parse(lblHospedeId.Text));

                    if (post.StatusCode == 201)
                    {
                        MessageBox.Show(post.Mensagem, "Cadastro de FNRH");
                        txtProfissao.Enabled = false;
                        txtNacionalidade.Enabled = false;
                        cmbSexo.Enabled = false;
                        txtIdentidade.Enabled = false;
                        txtUltimoDestino.Enabled = false;
                        txtProximoDestino.Enabled = false;
                        txtMotivoViagem.Enabled = false;
                        txtMeioDeTransporte.Enabled = false;
                        txtPlacaDoCarro.Enabled = false;
                        txtNumeroAcompanhantes.Enabled = false;
                        btnSalvarFNRH.Enabled = Enabled = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(post.Mensagem, "Cadastro de FNRH");
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Cadastro de FNRH");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastrarHospede fCadastrarHospede = new frmCadastrarHospede();
            fCadastrarHospede.Show();
            this.Close();
        }
    }
}
