using System;
using System.Windows.Forms;
using RecantoDosPapagaios.TelasSecundarias;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Business;

namespace RecantoDosPapagaios.TelasDeUsuarios
{
    public partial class frmHospede : Form
    {
        private readonly HospedeBusiness _hospedeBusiness;

        public int idFuncionario { get; set; }

        public Hospede Hospede;

        public frmHospede(int id)
        {
            InitializeComponent();

            _hospedeBusiness = new HospedeBusiness();

            idFuncionario = id;
        }

        private void frmHospede_Load(object sender, EventArgs e)
        {
            lstHospede.Clear();
            lstHospede.Columns.Insert(0, "ID", 160, HorizontalAlignment.Left);
            lstHospede.Columns.Insert(1, "Nome", 318, HorizontalAlignment.Left);
            lstHospede.Columns.Insert(2, "CPF", 234, HorizontalAlignment.Left);
        }

        private void btnBuscarHospedes_Click(object sender, EventArgs e)
        {
            try
            {
                frmHospede_Load(this, new EventArgs());
                
                Hospede hospede = null;

                if (!txtPesquisaHospede.Text.Trim().Equals(string.Empty))
                {
                    hospede = _hospedeBusiness.Obter(txtPesquisaHospede.Text);

                    if (hospede.Cpf != null)
                    {
                        ListViewItem listItem = lstHospede.Items.Add(hospede.Id.ToString());
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, hospede.NomeCompleto));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, hospede.Cpf));
                    }
                    else
                    {
                        MessageBox.Show("CPF não localizado.", "Hóspede");
                    }
                }
                else if (txtPesquisaHospede.Text.Trim().Equals(string.Empty))
                {
                    var hospedes = _hospedeBusiness.Obter();

                    Hospede = hospede;

                    foreach (Hospede item in hospedes)
                    {
                        ListViewItem listItem = lstHospede.Items.Add(item.Id.ToString());
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.NomeCompleto));
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Cpf));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Hóspede"
                );
            }
        }

        private void btnCadastrarNovoHospede_Click(object sender, EventArgs e)
        {
            frmCadastrarHospede fCadastrarHospede = new frmCadastrarHospede();
            fCadastrarHospede.Show();
        }

        private void lstHospede_DoubleClick(object sender, EventArgs e)
        {
            var hospede = _hospedeBusiness.Obter(int.Parse(lstHospede.SelectedItems[0].Text));

            Hospede = hospede;

            frmHospedeDetalhes fHospedeDetalhes = new frmHospedeDetalhes(Hospede);

            if (hospede != null)
            {
                fHospedeDetalhes.lblHospedeId.Text = hospede.Id.ToString();
                fHospedeDetalhes.txtNomeCompleto.Text = hospede.NomeCompleto;
                fHospedeDetalhes.txtEmail.Text = hospede.Contatos.Email;
                fHospedeDetalhes.txtCPF.Text = hospede.Cpf;
                fHospedeDetalhes.txtDataNascimento.Text = hospede.DataDeNascimento.ToString("dd/MM/yyyy");
                fHospedeDetalhes.txtCEP.Text = hospede.Endereco.Cep;
                fHospedeDetalhes.txtLogradouro.Text = hospede.Endereco.Logradouro;
                fHospedeDetalhes.txtNumeroResidencial.Text = hospede.Endereco.Numero;
                fHospedeDetalhes.txtComplemento.Text = hospede.Endereco.Complemento;
                fHospedeDetalhes.txtBairro.Text = hospede.Endereco.Bairro;
                fHospedeDetalhes.cmbUF.Items.Add(hospede.Endereco.Estado);
                fHospedeDetalhes.cmbUF.SelectedIndex = 0;
                fHospedeDetalhes.txtCidade.Text = hospede.Endereco.Cidade;
                fHospedeDetalhes.txtPais.Text = hospede.Endereco.Pais;
                fHospedeDetalhes.txtUsuario.Text = hospede.Usuario.NomeUsuario;
                fHospedeDetalhes.Show();
            }
        }

        private void txtPesquisaHospede_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscarHospedes_Click(btnBuscarHospedes, new EventArgs());
            }
        }

    }
}
