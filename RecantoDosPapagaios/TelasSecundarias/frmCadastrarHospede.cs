using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmCadastrarHospede : Form
    {
        private readonly HospedeBusiness _hospedeBusiness;

        public frmCadastrarHospede()
        {
            InitializeComponent();

            _hospedeBusiness = new HospedeBusiness();
        }
       
        private void frmCadastrarHospede_Load(object sender, EventArgs e)
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
        }

        private void btnSalvarNovoCadastro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeCompleto.Text.Trim().Equals(string.Empty) ||
                    txtEmail.Text.Trim().Equals(string.Empty) ||
                    txtCPF.Text.Trim().Equals(string.Empty) ||
                    txtCEP.Text.Trim().Equals(string.Empty) ||
                    txtNumeroResidencial.Text.Trim().Equals(string.Empty) ||
                    txtBairro.Text.Trim().Equals(string.Empty) ||
                    txtCidade.Text.Trim().Equals(string.Empty) ||
                    cmbUF.SelectedIndex.Equals(-1) ||
                    txtPais.Text.Trim().Equals(string.Empty) ||
                    txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("É necessário preencher todos os campos solicitados.",
                        "Cadastro de hóspede");
                }
                else if (txtSenha.Text != txtConfirmacaoSenha.Text)
                {
                    MessageBox.Show("Os campos 'Senha' e 'Confirme a senha' devem estar iguais.",
                        "Cadastro de hóspede");
                }
                else
                {
                    var hospede = new Hospede
                    {
                        NomeCompleto = txtNomeCompleto.Text,
                        Cpf = txtCPF.Text,
                        DataDeNascimento = dtpDataNascimento.Value,
                        Usuario = new UsuarioPessoa
                        {
                            NomeUsuario = txtUsuario.Text,
                            SenhaUsuario = txtSenha.Text,
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
                            Estado = cmbUF.Text,
                            Pais = txtPais.Text
                        }
                    };
                    
                    var resultado = _hospedeBusiness.Inserir(hospede);

                    if (resultado.StatusCode == 201)
                    {
                        MessageBox.Show(resultado.Mensagem, "Cadastro de hóspede");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(resultado.Mensagem, "Cadastro de hóspede");
                    }
                }
            }
            catch(ErrorException ex)
            {
                MessageBox.Show
               (
                   ex.Message, "Cadastro de hóspede"
               );
            }
            catch (FormatException ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Cadastro de hóspede"
                );
            }

        }
    }
}
