using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmHospedeDetalhes : Form
    {
        #region Atributos para salvar os valores dos campos txt
        string TxtNome;
        string TxtEmail;
        string TxtCpf;
        string TxtDataNascimento;
        string TxtCep;
        string TxtLogradouro;
        string TxtNumeroResidencial;
        string TxtComplemento;
        string TxtBairro;
        string TxtCidade;
        string TxtUf;
        string TxtPais;
        #endregion


        private readonly Hospede _hospede;

        private readonly HospedeBusiness _hospedeBusiness;

        public frmHospedeDetalhes(Hospede hospede)
        {
            InitializeComponent();

            _hospede = hospede;

            _hospedeBusiness = new HospedeBusiness();
        }

        private void frmHospedeDetalhes_Load(object sender, EventArgs e)
        {
            cmbUF.Items.Add("AC");
            cmbUF.Items.Add("AL");
            cmbUF.Items.Add("AP");
            cmbUF.Items.Add("AM");
            cmbUF.Items.Add("BA");
            cmbUF.Items.Add("CE");
            cmbUF.Items.Add("DF");
            cmbUF.Items.Add("ES");
            cmbUF.Items.Add("GO");
            cmbUF.Items.Add("MA");
            cmbUF.Items.Add("MT");
            cmbUF.Items.Add("MS");
            cmbUF.Items.Add("MG");
            cmbUF.Items.Add("PA");
            cmbUF.Items.Add("PB");
            cmbUF.Items.Add("PR");
            cmbUF.Items.Add("PE");
            cmbUF.Items.Add("PI");
            cmbUF.Items.Add("RJ");
            cmbUF.Items.Add("RN");
            cmbUF.Items.Add("RS");
            cmbUF.Items.Add("RO");
            cmbUF.Items.Add("RR");
            cmbUF.Items.Add("SC");
            cmbUF.Items.Add("SP");
            cmbUF.Items.Add("SE");
            cmbUF.Items.Add("TO");

            SalvaValoresAnteriores();
        }

        private void SalvaValoresAnteriores()
        {
            TxtNome = txtNomeCompleto.Text;
            TxtEmail = txtEmail.Text;
            TxtCpf = txtCPF.Text;
            TxtDataNascimento = txtDataNascimento.Text;
            TxtCep = txtCEP.Text;
            TxtLogradouro = txtLogradouro.Text;
            TxtNumeroResidencial = txtNumeroResidencial.Text;
            TxtComplemento = txtComplemento.Text;
            TxtBairro = txtBairro.Text;
            TxtCidade = txtCidade.Text;
            TxtUf = cmbUF.Text;
            TxtPais = txtPais.Text;
        }

        private void RetornaValoresAnteriores()
        {
            txtNomeCompleto.Text = TxtNome;
            txtEmail.Text = TxtEmail;
            txtCPF.Text = TxtCpf;
            txtDataNascimento.Text = TxtDataNascimento;
            txtCEP.Text = TxtCep;
            txtLogradouro.Text = TxtLogradouro;
            txtNumeroResidencial.Text = TxtNumeroResidencial;
            txtComplemento.Text = TxtComplemento;
            txtBairro.Text = TxtBairro;
            txtCidade.Text = TxtCidade;
            cmbUF.Text = TxtUf;
            txtPais.Text = TxtPais;
        }

        private void DesabilitaCamposDeEdicao()
        {
            txtNomeCompleto.Enabled = false;
            txtEmail.Enabled = false;
            txtCPF.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumeroResidencial.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbUF.Enabled = false;
            txtPais.Enabled = false;
            txtUsuario.Enabled = false;
            btnSalvarCadastro.Enabled = false;
            btnEditarHospede.Enabled = true;
            btnCancelarAtualizacao.Enabled = false;
        }

        private void btnEditarHospede_Click(object sender, EventArgs e)
        {
            SalvaValoresAnteriores();

            txtNomeCompleto.Enabled = true;
            txtEmail.Enabled = true;
            txtCPF.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumeroResidencial.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbUF.Enabled = true;
            txtPais.Enabled = true;

            btnSalvarCadastro.Enabled = true;
            btnCancelarAtualizacao.Enabled = true;
            btnEditarHospede.Enabled = false;
        }

        private void btnCancelarAtualizacao_Click(object sender, EventArgs e)
        {
            RetornaValoresAnteriores();
            btnSalvarCadastro.Enabled = false;
            btnEditarHospede.Enabled = true;
            btnSalvarCadastro.Enabled = false;
            btnCancelarAtualizacao.Enabled = false;
            DesabilitaCamposDeEdicao();
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeCompleto.Text.Trim().Equals(string.Empty) ||
                    txtEmail.Text.Trim().Equals(string.Empty) ||
                    txtCPF.Text.Trim().Equals(string.Empty) ||
                    txtDataNascimento.Text.Trim().Equals(string.Empty) ||
                    txtCEP.Text.Trim().Equals(string.Empty) ||
                    txtNumeroResidencial.Text.Trim().Equals(string.Empty) ||
                    txtComplemento.Text.Trim().Equals(string.Empty) ||
                    txtBairro.Text.Trim().Equals(string.Empty) ||
                    txtCidade.Text.Trim().Equals(string.Empty) ||
                    cmbUF.SelectedIndex.Equals(-1) ||
                    txtPais.Text.Trim().Equals(string.Empty) ||
                    txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("É necessário preencher todos os campos solicitados.",
                        "Informações de hóspede");
                }
                else
                {
                    var hospede = new Hospede
                    {
                        NomeCompleto = txtNomeCompleto.Text,
                        Cpf = txtCPF.Text,
                        DataDeNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                        Usuario = new UsuarioPessoa
                        {
                            NomeUsuario = txtUsuario.Text,
                            SenhaUsuario = "",
                        },
                        Contatos = new ContatosPessoa
                        {
                            Email = txtEmail.Text,
                            Celular = "",
                            Telefone = ""
                        },
                        Endereco = new EnderecoPessoa
                        {
                            Cep = txtCEP.Text,
                            Logradouro = txtLogradouro.Text,
                            Numero = txtNumeroResidencial.Text,
                            Complemento = txtComplemento.Text,
                            Bairro = txtBairro.Text,
                            Cidade = txtCidade.Text,
                            Estado = cmbUF.SelectedItem.ToString(),
                            Pais = txtPais.Text
                        }
                    };

                    var atualizar = _hospedeBusiness.Atualizar(hospede, _hospede.Id);

                    if (atualizar.StatusCode == 200)
                    {
                        MessageBox.Show(atualizar.Mensagem, "Informações de hóspede");
                        DesabilitaCamposDeEdicao();
                    }
                    else
                    {
                        MessageBox.Show(atualizar.Mensagem, "Informações de hóspede");
                    }
                }
            }
            catch (ErrorException ex)
            {
                MessageBox.Show
               (
                   ex.Message, "Cadastro de hóspede"
               );
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Informações de hóspede"
                );
            }
        }

        private void btnCadastrarFNRH_Click(object sender, EventArgs e)
        {
            var hospede = new Hospede();

            frmCadastrarFNRH fCadastrarFNRH = new frmCadastrarFNRH(hospede);
            fCadastrarFNRH.lblHospedeId.Text = lblHospedeId.Text;
            this.Close();
            fCadastrarFNRH.Show();
        }
    }
}
