using System;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using RecantoDosPapagaios.TelasDeUsuarios;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmFuncionarios : Form
    {
        private readonly FuncionarioBusiness _funcionarioBusiness;

        private readonly LoginBusiness _loginBusiness;

        public int idFuncionario { get; set; }

        public frmFuncionarios(int id)
        {
            InitializeComponent();

            _funcionarioBusiness = new FuncionarioBusiness();

            _loginBusiness = new LoginBusiness();

            idFuncionario = id;
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            #region Codigo

            lstFuncionario.Clear();
            lstFuncionario.Columns.Insert(0, "ID", 100, HorizontalAlignment.Left);
            lstFuncionario.Columns.Insert(1, "Nome", 250, HorizontalAlignment.Left);
            lstFuncionario.Columns.Insert(2, "CPF", 180, HorizontalAlignment.Left);
            lstFuncionario.Columns.Insert(3, "Cargo", 234, HorizontalAlignment.Left);

            #endregion Codigo
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            #region RequestEInstanciamento

            try
            {
                frmFuncionarios_Load(this, new EventArgs());
                
                int count = 0;

                if (!txtPesquisaFuncionario.Text.Trim().Equals(string.Empty))
                {
                    var funcionario = _funcionarioBusiness.Obter(txtPesquisaFuncionario.Text);

                    if (funcionario != null)
                    {
                        ListViewItem listItem = lstFuncionario.Items.Add(funcionario.Id.ToString());
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.NomeCompleto));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.Cpf));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.Cargo));

                        count++;
                    }
                    else
                    {
                        MessageBox.Show("CPF não localizado.", "Funcionários");
                    }

                    if (count == 0)
                        lblTotalFuncionarios.Text = "Total de funcionários localizados: " + count.ToString();
                }
                else
                {
                    var funcionarios = _funcionarioBusiness.Obter();

                    if (funcionarios.Count > 0)
                    {
                        foreach (FuncionarioGetJson funcionario in funcionarios)
                        {
                            ListViewItem listItem = lstFuncionario.Items.Add(funcionario.Id.ToString());
                            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.NomeCompleto));
                            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.Cpf));
                            listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, funcionario.Cargo));

                            count++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Funcionários"
                );
            }

            #endregion RequestEInstanciamento
        }

        private void btnCadastrarNovoFuncionario_Click(object sender, EventArgs e)
        {
            #region Codigo

            frmMinhaConta fMinhaConta = new frmMinhaConta(true);

            fMinhaConta.txtNomeCompleto.Enabled = true;
            fMinhaConta.txtEmail.Enabled = true;
            fMinhaConta.txtCargo.Enabled = true;
            fMinhaConta.txtCPF.Enabled = true;
            fMinhaConta.txtDataNascimento.Enabled = true;
            fMinhaConta.txtCEP.Enabled = true;
            fMinhaConta.txtLogradouro.Enabled = true;
            fMinhaConta.txtNumeroResidencial.Enabled = true;
            fMinhaConta.txtComplemento.Enabled = true;
            fMinhaConta.txtBairro.Enabled = true;
            fMinhaConta.txtCidade.Enabled = true;
            fMinhaConta.cmbUF.Enabled = true;
            fMinhaConta.txtPais.Enabled = true;
            fMinhaConta.cmbSexo.Enabled = true;
            fMinhaConta.txtRG.Enabled = true;
            fMinhaConta.txtNacionalidade.Enabled = true;
            fMinhaConta.txtTelefone.Enabled = true;
            fMinhaConta.txtCelular.Enabled = true;
            fMinhaConta.txtSetor.Enabled = true;
            fMinhaConta.txtSalario.Enabled = true;
            fMinhaConta.cmbCategoriaAcesso.Enabled = true;
            fMinhaConta.txtNomeUsuario.Enabled = true;
            fMinhaConta.txtSenhaUsuario.Enabled = true;
            fMinhaConta.txtPerguntaSeguranca.Enabled = true;
            fMinhaConta.txtRespostaSeguranca.Enabled = true;
            fMinhaConta.txtBanco.Enabled = true;
            fMinhaConta.txtAgencia.Enabled = true;
            fMinhaConta.txtNumeroConta.Enabled = true;

            fMinhaConta.btnEditarCadastro.Enabled = false;
            fMinhaConta.btnEditarCadastro.Visible = false;
            fMinhaConta.btnCancelarAtualizacao.Enabled = false;
            fMinhaConta.btnCancelarAtualizacao.Visible = false;
            fMinhaConta.btnCancelarAtualizacao.Enabled = true;
            fMinhaConta.btnSalvarCadastro.Enabled = true;
            fMinhaConta.Text = "Cadastro de funcionário";
            fMinhaConta.lblTitulo.Text = "Cadastrar novo funcionário";
            fMinhaConta.Show();

            #endregion Codigo
        }

        private void lstFuncionario_DoubleClick(object sender, EventArgs e)
        {
            frmMinhaConta fMinhaConta = new frmMinhaConta();

            #region RequestEInstanciamento

            try
            {
                var valido = int.TryParse(lstFuncionario.SelectedItems[0].Text, out int idSelecionado);

                if (valido)
                {
                    var funcionario = _funcionarioBusiness.Obter(idSelecionado);

                    if (funcionario != null)
                    {
                        #region RequestPerguntaDeSeguranca

                        fMinhaConta.idFuncionario = funcionario.Id;

                        PerguntaDeSeguranca perguntaDeSeguranca;

                        var perguntaDeSegurancaRequest = _loginBusiness.EncontrarConta(funcionario.Cpf);

                        if (perguntaDeSegurancaRequest != null)
                        {
                            perguntaDeSeguranca = new PerguntaDeSeguranca
                            {
                                PerguntaSeguranca = perguntaDeSegurancaRequest.PerguntaSeguranca,
                                RespostaSeguranca = perguntaDeSegurancaRequest.RespostaSeguranca
                            };
                        }
                        else
                        {
                            perguntaDeSeguranca = new PerguntaDeSeguranca
                            {
                                PerguntaSeguranca = "",
                                RespostaSeguranca = ""
                            };
                        }

                        #endregion RequestPerguntaDeSeguranca

                        fMinhaConta.txtNomeCompleto.Text = funcionario.NomeCompleto;
                        fMinhaConta.txtEmail.Text = funcionario.Contatos.Email;
                        fMinhaConta.txtCargo.Text = funcionario.Cargo;
                        fMinhaConta.txtCPF.Text = funcionario.Cpf;
                        fMinhaConta.txtDataNascimento.Text = funcionario.DataDeNascimento.ToString("dd/MM/yyyy");
                        fMinhaConta.txtRG.Text = funcionario.Rg;
                        fMinhaConta.txtNacionalidade.Text = funcionario.Nacionalidade;

                        if (funcionario.Sexo.Equals("M"))
                            fMinhaConta.cmbSexo.SelectedIndex = 0;
                        else if (funcionario.Sexo.Equals("F"))
                            fMinhaConta.cmbSexo.SelectedIndex = 1;
                        else
                            fMinhaConta.cmbSexo.SelectedIndex = 2;

                        fMinhaConta.txtTelefone.Text = funcionario.Contatos.Telefone;
                        fMinhaConta.txtCelular.Text = funcionario.Contatos.Celular;
                        fMinhaConta.txtSetor.Text = funcionario.Setor;
                        fMinhaConta.txtSalario.Text = funcionario.Salario.ToString();

                        if (funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
                            fMinhaConta.cmbCategoriaAcesso.SelectedIndex = 0;
                        else
                            fMinhaConta.cmbCategoriaAcesso.SelectedIndex = 1;

                        fMinhaConta.txtNomeUsuario.Text = funcionario.Usuario.NomeUsuario;
                        fMinhaConta.txtPerguntaSeguranca.Text = perguntaDeSeguranca.PerguntaSeguranca;
                        fMinhaConta.txtRespostaSeguranca.Text = perguntaDeSeguranca.RespostaSeguranca;
                        fMinhaConta.txtBanco.Text = funcionario.DadosBancarios.Banco;
                        fMinhaConta.txtAgencia.Text = funcionario.DadosBancarios.Agencia;
                        fMinhaConta.txtNumeroConta.Text = funcionario.DadosBancarios.NumeroDaConta;

                        fMinhaConta.txtCEP.Text = funcionario.Endereco.Cep;
                        fMinhaConta.txtLogradouro.Text = funcionario.Endereco.Logradouro;
                        fMinhaConta.txtNumeroResidencial.Text = funcionario.Endereco.Numero;
                        fMinhaConta.txtComplemento.Text = funcionario.Endereco.Complemento;
                        fMinhaConta.txtBairro.Text = funcionario.Endereco.Bairro;
                        fMinhaConta.txtCidade.Text = funcionario.Endereco.Cidade;
                        fMinhaConta.cmbUF.SelectedItem = funcionario.Endereco.Estado;
                        fMinhaConta.txtPais.Text = funcionario.Endereco.Pais;

                        fMinhaConta.btnEditarCadastro.Enabled = true;
                        fMinhaConta.btnCancelarAtualizacao.Enabled = false;
                        fMinhaConta.btnSalvarCadastro.Enabled = false;
                        fMinhaConta.lblTitulo.Text = "Dados do colaborador";
                        fMinhaConta.Text = "Dados do colaborador";
                        fMinhaConta.Show();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não localizado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Funcionários"
                );
            }

            #endregion RequestEInstanciamento
        }

        private void txtPesquisaFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscarFuncionario_Click(btnBuscarFuncionario, new EventArgs());
            }
        }

    }
}
