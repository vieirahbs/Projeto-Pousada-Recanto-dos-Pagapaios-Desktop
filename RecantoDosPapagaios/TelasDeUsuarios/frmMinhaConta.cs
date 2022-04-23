using System;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;

namespace RecantoDosPapagaios.TelasDeUsuarios
{
    public partial class frmMinhaConta : Form
    {
        private readonly FuncionarioBusiness _funcionarioBusiness;

        private readonly LoginBusiness _loginBusiness;

        public Funcionario FuncionarioLogado;

        public FuncionarioGetJson Funcionario { get; set; }
        public int idFuncionario { get; set; }

        public string Senha { get; set; }
        public bool Cadastro { get; set; }

        #region Atributos para salvar os dados do formulário
        public string TxtNome;
        public string TxtSexo;
        public string TxtEmail;
        public string TxtDataNascimento;
        public string TxtRg;
        public string TxtCpf;
        public string TxtNacionalidade;
        public string TxtTelefone;
        public string TxtCelular;
        public string TxtCep;
        public string TxtLogradouro;
        public string TxtNumeroResidencial;
        public string TxtComplemento;
        public string TxtBairro;
        public string TxtCidade;
        public string TxtUf;
        public string TxtPais;
        public string TxtCargo;
        public string TxtSetor;
        public string TxtSalario;
        public string TxtCategoriaAcesso;
        public string TxtBanco;
        public string TxtAgencia;
        public string TxtConta;
        public string TxtPerguntaSeguranca;
        public string TxtRespostaSeguranca;

        #endregion

        public frmMinhaConta(int id, string senha, bool cadastro, FuncionarioGetJson funcionario)
        {
            InitializeComponent();

            idFuncionario = id;

            Senha = senha;

            Cadastro = cadastro;

            Funcionario = funcionario;

            _funcionarioBusiness = new FuncionarioBusiness();

            _loginBusiness = new LoginBusiness();

            #region DefinicaoUF

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

            #endregion DefinicaoUF

            #region DefinicaoSexo
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.Items.Add("O");
            #endregion

            #region DefinicaoCategoriaAcesso
            cmbCategoriaAcesso.Items.Add("Recepção");
            cmbCategoriaAcesso.Items.Add("Administrativa");
            #endregion
        }

        public frmMinhaConta(bool cadastro)
        {
            Cadastro = cadastro;

            InitializeComponent();

            _funcionarioBusiness = new FuncionarioBusiness();

            _loginBusiness = new LoginBusiness();

            #region DefinicaoUF

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

            #endregion DefinicaoUF

            #region DefinicaoSexo
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.Items.Add("O");
            #endregion

            #region DefinicaoCategoriaAcesso
            cmbCategoriaAcesso.Items.Add("Recepção");
            cmbCategoriaAcesso.Items.Add("Administrativa");
            #endregion
        }

        public frmMinhaConta()
        {
            InitializeComponent();

            _funcionarioBusiness = new FuncionarioBusiness();

            _loginBusiness = new LoginBusiness();

            #region DefinicaoUF

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

            #endregion DefinicaoUF

            #region DefinicaoSexo
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.Items.Add("O");
            #endregion

            #region DefinicaoCategoriaAcesso
            cmbCategoriaAcesso.Items.Add("Recepção");
            cmbCategoriaAcesso.Items.Add("Administrativa");
            #endregion
        }

        private void frmMinhaConta_Load(object sender, EventArgs e)
        {
            if (Funcionario != null)
            {
                if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
                {
                    btnEditarCadastro.Enabled = false;
                    btnEditarCadastro.Visible = false;
                    btnSalvarCadastro.Enabled = false;
                    btnSalvarCadastro.Visible = false;
                    btnCancelarAtualizacao.Enabled = false;
                    btnCancelarAtualizacao.Visible = false;
                }
            }

            if (idFuncionario != 0)
            {
                FuncionarioGetJson funcionario;

                try
                {
                    #region EfetuandoRequestEInstanciandoObjeto

                    funcionario = _funcionarioBusiness.Obter(idFuncionario);

                    if (funcionario != null)
                    {
                        FuncionarioLogado = new Funcionario
                        {
                            Id = funcionario.Id,
                            NomeCompleto = funcionario.NomeCompleto,
                            Cpf = funcionario.Cpf,
                            Nacionalidade = funcionario.Nacionalidade,
                            DataDeNascimento = funcionario.DataDeNascimento,
                            Sexo = funcionario.Sexo,
                            Rg = funcionario.Rg,
                            Cargo = funcionario.Cargo,
                            Setor = funcionario.Setor,
                            Salario = funcionario.Salario,
                            Usuario = new UsuarioPessoa
                            {
                                NomeUsuario = funcionario.Usuario.NomeUsuario
                            },
                            Contatos = new ContatosPessoa
                            {
                                Email = funcionario.Contatos.Email,
                                Celular = funcionario.Contatos.Celular,
                                Telefone = funcionario.Contatos.Telefone
                            },
                            Endereco = new EnderecoPessoa
                            {
                                Cep = funcionario.Endereco.Cep,
                                Logradouro = funcionario.Endereco.Logradouro,
                                Numero = funcionario.Endereco.Numero,
                                Complemento = funcionario.Endereco.Complemento,
                                Bairro = funcionario.Endereco.Bairro,
                                Cidade = funcionario.Endereco.Cidade,
                                Estado = funcionario.Endereco.Estado,
                                Pais = funcionario.Endereco.Pais
                            },
                            DadosBancarios = new DadosBancarios
                            {
                                Banco = funcionario.DadosBancarios.Banco,
                                Agencia = funcionario.DadosBancarios.Agencia,
                                NumeroDaConta = funcionario.DadosBancarios.NumeroDaConta
                            },
                            CategoriaAcesso = new CategoriaAcesso
                            {
                                Descricao = funcionario.CategoriaAcesso.Descricao
                            }
                        };

                        if (FuncionarioLogado.CategoriaAcesso.Descricao.Equals("Administrativo"))
                            FuncionarioLogado.CategoriaAcesso.Id = 1;
                        else
                            FuncionarioLogado.CategoriaAcesso.Id = 2;

                        var perguntaDeSeguranca = _loginBusiness.EncontrarConta(txtCPF.Text);

                        if (perguntaDeSeguranca != null)
                        {
                            FuncionarioLogado.PerguntaDeSeguranca = new PerguntaDeSeguranca
                            {
                                PerguntaSeguranca = perguntaDeSeguranca.PerguntaSeguranca,
                                RespostaSeguranca = perguntaDeSeguranca.RespostaSeguranca
                            };
                        }
                        else
                        {
                            FuncionarioLogado.PerguntaDeSeguranca = new PerguntaDeSeguranca
                            {
                                PerguntaSeguranca = "",
                                RespostaSeguranca = ""
                            };
                        }

                        txtNomeCompleto.Text = funcionario.NomeCompleto;
                        txtEmail.Text = funcionario.Contatos.Email;
                        txtCargo.Text = funcionario.Cargo;
                        txtCPF.Text = funcionario.Cpf;
                        txtDataNascimento.Text = funcionario.DataDeNascimento.ToString("dd/MM/yyyy");
                        txtRG.Text = funcionario.Rg;
                        txtNacionalidade.Text = funcionario.Nacionalidade;
                        cmbSexo.SelectedItem = funcionario.Sexo;
                        txtTelefone.Text = funcionario.Contatos.Telefone;
                        txtCelular.Text = funcionario.Contatos.Celular;
                        txtSetor.Text = funcionario.Setor;
                        txtSalario.Text = funcionario.Salario.ToString();

                        if (funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
                            cmbCategoriaAcesso.SelectedIndex = 0;
                        else
                            cmbCategoriaAcesso.SelectedIndex = 1;

                        txtNomeUsuario.Text = funcionario.Usuario.NomeUsuario;

                        if (Senha != null)
                            txtSenhaUsuario.Text = Senha;

                        txtPerguntaSeguranca.Text = FuncionarioLogado.PerguntaDeSeguranca.PerguntaSeguranca;
                        txtRespostaSeguranca.Text = FuncionarioLogado.PerguntaDeSeguranca.RespostaSeguranca;
                        txtBanco.Text = funcionario.DadosBancarios.Banco;
                        txtAgencia.Text = funcionario.DadosBancarios.Agencia;
                        txtNumeroConta.Text = funcionario.DadosBancarios.NumeroDaConta;
                        txtCEP.Text = funcionario.Endereco.Cep;
                        txtLogradouro.Text = funcionario.Endereco.Logradouro;
                        txtNumeroResidencial.Text = funcionario.Endereco.Numero;
                        txtComplemento.Text = funcionario.Endereco.Complemento;
                        txtBairro.Text = funcionario.Endereco.Bairro;
                        txtCidade.Text = funcionario.Endereco.Cidade;
                        cmbUF.SelectedItem = funcionario.Endereco.Estado;
                        txtPais.Text = funcionario.Endereco.Pais;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consultar dados do funcionário.");
                    }

                    #endregion EfetuandoRequestEInstanciandoObjeto

                    SalvaValoresAnteriores();
                }
                catch (ErrorException ex)
                {
                    MessageBox.Show
                   (
                       ex.Message, "Cadastro de funcionário"
                   );
                }
                catch (Exception ex)
                {
                    MessageBox.Show
                    (
                        $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Minha conta"
                    );
                }

                btnCancelarAtualizacao.Enabled = false;
            }
        }

        private void SalvaValoresAnteriores()
        {
            TxtNome = txtNomeCompleto.Text;
            TxtSexo = cmbSexo.Text;
            TxtEmail = txtEmail.Text;
            TxtDataNascimento = txtDataNascimento.Text;
            TxtRg = txtRG.Text;
            TxtCpf = txtCPF.Text;
            TxtNacionalidade = txtNacionalidade.Text;
            TxtTelefone = txtTelefone.Text;
            TxtCelular = txtCelular.Text;
            TxtCep = txtCEP.Text;
            TxtLogradouro = txtLogradouro.Text;
            TxtNumeroResidencial = txtNumeroResidencial.Text;
            TxtComplemento = txtComplemento.Text;
            TxtBairro = txtBairro.Text;
            TxtCidade = txtCidade.Text;
            TxtUf = cmbUF.Text; ;
            TxtPais = txtPais.Text;
            TxtCargo = txtCargo.Text;
            TxtSetor = txtSetor.Text;
            TxtSalario = txtSalario.Text;
            TxtCategoriaAcesso = cmbCategoriaAcesso.Text;
            TxtBanco = txtBanco.Text;
            TxtAgencia = txtAgencia.Text;
            TxtConta = txtNumeroConta.Text;
        }

        private void RetornaValoresAnteriores()
        {
            txtNomeCompleto.Text = TxtNome;
            cmbSexo.SelectedItem = TxtSexo;
            txtEmail.Text = TxtEmail;
            txtDataNascimento.Text = TxtDataNascimento;
            txtRG.Text = TxtRg;
            txtCPF.Text = TxtCpf = txtCPF.Text;
            txtNacionalidade.Text = TxtNacionalidade;
            txtTelefone.Text = TxtTelefone;
            txtCelular.Text = TxtCelular;
            txtCEP.Text = TxtCep;
            txtLogradouro.Text = TxtLogradouro;
            txtNumeroResidencial.Text = TxtNumeroResidencial;
            txtComplemento.Text = TxtComplemento;
            txtBairro.Text = TxtBairro;
            txtCidade.Text = TxtCidade;
            cmbUF.SelectedItem = TxtUf;
            txtPais.Text = TxtPais;
            txtCargo.Text = TxtCargo;
            txtSetor.Text = TxtSetor;
            txtSalario.Text = TxtSalario;
            cmbCategoriaAcesso.SelectedItem = TxtCategoriaAcesso;
            txtBanco.Text = TxtBanco;
            txtAgencia.Text = TxtAgencia;
            txtNumeroConta.Text = TxtConta;
        }

        private void DesabilitaCamposDeEdicao()
        {
            #region Codigo

            txtNomeCompleto.Enabled = false;
            txtEmail.Enabled = false;
            txtCPF.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtRG.Enabled = false;
            txtNacionalidade.Enabled = false;
            cmbSexo.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;

            txtCEP.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumeroResidencial.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cmbUF.Enabled = false;
            txtPais.Enabled = false;

            txtCargo.Enabled = false;
            txtSetor.Enabled = false;
            txtSalario.Enabled = false;

            txtNomeUsuario.Enabled = false;
            txtSenhaUsuario.Enabled = false;
            txtPerguntaSeguranca.Enabled = false;
            txtRespostaSeguranca.Enabled = false;
            cmbCategoriaAcesso.Enabled = false;

            txtBanco.Enabled = false;
            txtAgencia.Enabled = false;
            txtNumeroConta.Enabled = false;

            btnSalvarCadastro.Enabled = false;
            btnEditarCadastro.Enabled = true;
            btnCancelarAtualizacao.Enabled = false;

            #endregion Codigo
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            #region Codigo

            SalvaValoresAnteriores();

            txtNomeCompleto.Enabled = true;
            txtEmail.Enabled = true;
            txtCPF.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtRG.Enabled = true;
            txtNacionalidade.Enabled = true;
            cmbSexo.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;

            txtCEP.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumeroResidencial.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbUF.Enabled = true;
            txtPais.Enabled = true;

            txtCargo.Enabled = true;
            txtSetor.Enabled = true;
            txtSalario.Enabled = true;
            
            txtSenhaUsuario.Enabled = true;
            cmbCategoriaAcesso.Enabled = true;

            txtBanco.Enabled = true;
            txtAgencia.Enabled = true;
            txtNumeroConta.Enabled = true;

            btnSalvarCadastro.Enabled = true;
            btnCancelarAtualizacao.Enabled = true;
            btnEditarCadastro.Enabled = false;

            #endregion Codigo
        }

        private void btnCancelarAtualizacao_Click_1(object sender, EventArgs e)
        {
            #region Codigo
            RetornaValoresAnteriores();
            btnSalvarCadastro.Enabled = false;
            btnEditarCadastro.Enabled = true;
            btnSalvarCadastro.Enabled = false;
            btnCancelarAtualizacao.Enabled = false;

            DesabilitaCamposDeEdicao();

            #endregion Codigo
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeCompleto.Text.Trim().Equals(string.Empty) ||
                    txtEmail.Text.Trim().Equals(string.Empty) ||
                    txtCargo.Text.Trim().Equals(string.Empty) ||
                    txtRG.Text.Trim().Equals(string.Empty) ||
                    txtNacionalidade.Text.Trim().Equals(string.Empty) ||
                    cmbSexo.SelectedIndex.Equals(-1) ||
                    txtTelefone.Text.Trim().Equals(string.Empty) ||
                    txtCelular.Text.Trim().Equals(string.Empty) ||
                    txtCPF.Text.Trim().Equals(string.Empty) ||
                    txtDataNascimento.Text.Trim().Equals(string.Empty) ||
                    txtEmail.Text.Trim().Equals(string.Empty) ||
                    txtCEP.Text.Trim().Equals(string.Empty) ||
                    txtLogradouro.Text.Trim().Equals(string.Empty) ||
                    txtNumeroResidencial.Text.Trim().Equals(string.Empty) ||
                    txtComplemento.Text.Trim().Equals(string.Empty) ||
                    txtBairro.Text.Trim().Equals(string.Empty) ||
                    txtCidade.Text.Trim().Equals(string.Empty) ||
                    cmbUF.SelectedIndex.Equals(-1) ||
                    txtSetor.Text.Trim().Equals(string.Empty) ||
                    txtSalario.Text.Trim().Equals(string.Empty) ||
                    cmbCategoriaAcesso.SelectedIndex.Equals(-1) ||
                    txtNomeUsuario.Text.Trim().Equals(string.Empty) ||
                    txtBanco.Text.Trim().Equals(string.Empty) ||
                    txtAgencia.Text.Trim().Equals(string.Empty) ||
                    txtNumeroConta.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("É necessário preencher todos os campos solicitados.", "Minha conta");
                }
                else
                {
                    #region SerealizandoJsonEEfetuandoRequest

                    string senha;

                    if (txtSenhaUsuario.Text == "")
                        senha = "";
                    else
                        senha = txtSenhaUsuario.Text;

                    Funcionario funcionarioObject = new Funcionario
                    {
                        NomeCompleto = txtNomeCompleto.Text,
                        Cpf = txtCPF.Text,
                        Nacionalidade = txtNacionalidade.Text,
                        DataDeNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                        Sexo = cmbSexo.SelectedItem.ToString(),
                        Rg = txtRG.Text,
                        Cargo = txtCargo.Text,
                        Setor = txtSetor.Text,
                        Salario = Convert.ToDouble(txtSalario.Text),
                        Usuario = new UsuarioPessoa
                        {
                            NomeUsuario = txtNomeUsuario.Text,
                            SenhaUsuario = senha
                        },
                        Contatos = new ContatosPessoa
                        {
                            Email = txtEmail.Text,
                            Celular = txtCelular.Text,
                            Telefone = txtTelefone.Text
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
                        },
                        DadosBancarios = new DadosBancarios
                        {
                            Banco = txtBanco.Text,
                            Agencia = txtAgencia.Text,
                            NumeroDaConta = txtNumeroConta.Text
                        },
                        CategoriaAcesso = new CategoriaAcesso
                        {
                            Id = cmbCategoriaAcesso.SelectedIndex + 1
                        },
                        PerguntaDeSeguranca = new PerguntaDeSeguranca
                        {
                            PerguntaSeguranca = txtPerguntaSeguranca.Text,
                            RespostaSeguranca = txtRespostaSeguranca.Text
                        }
                    };

                    if (Cadastro)
                    {
                        var inserir = _funcionarioBusiness.Inserir(funcionarioObject);

                        if (inserir.StatusCode == 201)
                        {
                            MessageBox.Show(inserir.Mensagem, "Minha conta");

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show
                            (
                                $"O seguinte erro aconteceu ao realizar o processo: {inserir.Mensagem}", "Minha conta"
                            );
                        }
                    }
                    else
                    {
                        var atualizar = _funcionarioBusiness.Atualizar(funcionarioObject, idFuncionario);

                        if (atualizar.StatusCode == 200)
                        {
                            MessageBox.Show(atualizar.Mensagem, "Minha conta");

                            DesabilitaCamposDeEdicao();
                        }
                        else
                        {
                            MessageBox.Show
                            (
                                $"O seguinte erro aconteceu ao realizar o processo: {atualizar.Mensagem}", "Minha conta"
                            );
                        }
                    }



                    #endregion SerealizandoJsonEEfetuandoRequest
                }
            }
            catch (ErrorException ex)
            {
                MessageBox.Show
               (
                   ex.Message, "Cadastro de funcionário"
               );
            }
            catch (Exception msg)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {msg.Message}", "Minha conta"
                );
            }
        }
    }
}
