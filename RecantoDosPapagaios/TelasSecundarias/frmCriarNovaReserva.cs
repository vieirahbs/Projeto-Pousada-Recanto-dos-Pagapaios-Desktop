using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmCriarNovaReserva : Form
    {
        private readonly HospedeBusiness _hospedeBusiness;

        private readonly ReservaBusiness _reservaBusiness;

        public Hospede Hospede { get; set; }

        public int Quantidade { get; set; }

        public frmCriarNovaReserva()
        {
            InitializeComponent();

            _hospedeBusiness = new HospedeBusiness();

            _reservaBusiness = new ReservaBusiness();
        }

        #region Botões aumentar e diminuir a quantidade de acompanhantes
        private void btnAdultoMais_Click(object sender, EventArgs e)
        {
            int qtd;

            if (cmbSelecionarChale.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Primeiro selecione o chalé desejado, " +
                    "pois o limite de hóspedes pode variar de acordo com o chalé.", "Criar reserva");
                return;
            }
            else if (cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 1)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 2)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 3)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 4)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 5)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 6)"))
            {
                if (int.Parse(lblAdultoQtd.Text) + int.Parse(lblCriancaQtd.Text) < 3)
                {
                    if (int.Parse(lblAdultoQtd.Text) == 0 || int.Parse(lblAdultoQtd.Text) < 3)
                    {
                        qtd = int.Parse(lblAdultoQtd.Text) + 1;

                        Quantidade = Quantidade + 1;

                        lblAdultoQtd.Text = qtd.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Para os chalés 'Standard', só é possível selecionar" +
                        ", no máximo, 4 hóspedes, somando adultos e crianças.", "Criar reserva");
                    return;
                }
            }
            else
            {
                if (int.Parse(lblAdultoQtd.Text) + int.Parse(lblCriancaQtd.Text) < 2)
                {
                    if (int.Parse(lblAdultoQtd.Text) == 0 || int.Parse(lblAdultoQtd.Text) < 2)
                    {
                        qtd = int.Parse(lblAdultoQtd.Text) + 1;
                        Quantidade = Quantidade + 1;
                        lblAdultoQtd.Text = qtd.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Para os chalés 'Superior' e 'Master', só é possível selecionar" +
                        ", no máximo, 3 hóspedes, somando adultos e crianças.", "Criar reserva");
                    return;
                }
            }

        }

        private void btnAdultoMenos_Click(object sender, EventArgs e)
        {
            int qtd;
            
            if (int.Parse(lblAdultoQtd.Text) > 0)
            {
                qtd = int.Parse(lblAdultoQtd.Text) - 1;

                Quantidade = Quantidade - 1;

                lblAdultoQtd.Text = qtd.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnCriancaMais_Click(object sender, EventArgs e)
        {
            int qtd;

            if (cmbSelecionarChale.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Primeiro selecione o chalé desejado, " +
                    "pois o limite de hóspedes pode variar de acordo com o chalé.", "Criar reserva");
                return;
            }
            else if (cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 1)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 2)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 3)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 4)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 5)") ||
                    cmbSelecionarChale.SelectedItem.Equals("Standard (Chalé 6)"))
            {
                if (int.Parse(lblAdultoQtd.Text) + int.Parse(lblCriancaQtd.Text) < 4)
                {
                    if (int.Parse(lblCriancaQtd.Text) == 0 || int.Parse(lblCriancaQtd.Text) < 4)
                    {
                        qtd = int.Parse(lblCriancaQtd.Text) + 1;

                        Quantidade = Quantidade + 1;

                        lblCriancaQtd.Text = qtd.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Para os chalés 'Standard', só é possível selecionar" +
                        ", no máximo, 4 hóspedes, somando adultos e crianças.");
                    return;
                }
            }
            else
            {
                if (int.Parse(lblAdultoQtd.Text) + int.Parse(lblCriancaQtd.Text) < 3)
                {
                    if (int.Parse(lblCriancaQtd.Text) == 0 || int.Parse(lblCriancaQtd.Text) < 3)
                    {
                        qtd = int.Parse(lblCriancaQtd.Text) + 1;
                        lblCriancaQtd.Text = qtd.ToString();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Para os chalés 'Superior' e 'Master', só é possível selecionar" +
                        ", no máximo, 3 hóspedes, somando adultos e crianças.");
                    return;
                }
            }
        }

        private void btnCriancaMenos_Click(object sender, EventArgs e)
        {
            int qtd;

            if (int.Parse(lblCriancaQtd.Text) > 0)
            {
                qtd = int.Parse(lblCriancaQtd.Text) - 1;

                Quantidade = Quantidade - 1;

                lblCriancaQtd.Text = qtd.ToString();
            }
            else
            {
                return;
            }
        }

        #endregion

        private void frmCriarNovaReserva_Load(object sender, EventArgs e)
        {
            cmbSelecionarChale.Items.Add("Standard (Chalé 1)");
            cmbSelecionarChale.Items.Add("Standard (Chalé 2)");
            cmbSelecionarChale.Items.Add("Standard (Chalé 3)");
            cmbSelecionarChale.Items.Add("Standard (Chalé 4)");
            cmbSelecionarChale.Items.Add("Standard (Chalé 5)");
            cmbSelecionarChale.Items.Add("Standard (Chalé 6)");
            cmbSelecionarChale.Items.Add("Superior (Chalé 7)");
            cmbSelecionarChale.Items.Add("Superior (Chalé 8)");
            cmbSelecionarChale.Items.Add("Master (Chalé 9)");
            cmbSelecionarChale.Items.Add("Master (Chalé 10)");

            cmbPagamento.Items.Add("Dinheiro");
            cmbPagamento.Items.Add("Cartão de Débito");
            cmbPagamento.Items.Add("Cartão de Crédito");
            cmbPagamento.Items.Add("Transferência Bancária");
            cmbPagamento.Items.Add("Deposito Bancário");
            cmbPagamento.Items.Add("PIX");
        }

        private void cmbSelecionarChale_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAdultoQtd.Text = "0";
            lblCriancaQtd.Text = "0";
        }

        private void btnSalvarReserva_Click(object sender, EventArgs e)
        {
            DateTime checkin = dtpCheckIn.Value;
            DateTime checkout = dtpCheckOut.Value;
            if (txtCPFBusca.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe o CPF do hóspede.", "Criar reserva");
            }
            else if (cmbSelecionarChale.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Selecione o chalé desejado.", "Criar reserva");
                return;
            }
            else if (checkin > checkout)
            {
                MessageBox.Show("A data de check-in não pode ser superior a data de check-out.", "Criar reserva");
                return;
            }
            else if (checkin < DateTime.Today || checkout < DateTime.Today)
            {
                MessageBox.Show("A data de check-in ou check-out não pode ser antes de " + 
                                DateTime.Now.Date.ToShortDateString(), "Criar reserva");
                return;
            }
            else if (int.Parse(lblAdultoQtd.Text) == 0)
            {
                MessageBox.Show("Só será possível criar a reserva se a quantidade de hóspede adulto " +
                    "for maior do que zero", "Criar reserva");
                return;
            }
            else if (cmbPagamento.SelectedIndex == - 1)
            {
                MessageBox.Show("informe a forma de pagamento", "Criar reserva");
                return;
            }
            else
            {
                if (Hospede == null)
                {
                    MessageBox.Show("É necessário informar o CPF do hóspede.");
                }
                else
                {
                    var reserva = new Reserva
                    {
                        Hospede = new Hospede
                        {
                            Id = Hospede.Id
                        },
                        Acomodacao = new Acomodacao
                        {
                            Id = cmbSelecionarChale.SelectedIndex + 1
                        },
                        Pagamento = new Pagamento
                        {
                            TipoPagamento = new TipoPagamento
                            {
                                Id = cmbPagamento.SelectedIndex + 1
                            }
                        },
                        DataCheckIn = dtpCheckIn.Value,
                        DataCheckOut = dtpCheckOut.Value,
                        Acompanhantes = Quantidade
                    };

                    try
                    {
                        var retorno = _reservaBusiness.Inserir(reserva);

                        if (retorno.StatusCode == 201)
                        {
                            MessageBox.Show(retorno.Mensagem);

                            txtCPFBusca.Clear();
                            dtpCheckIn.Value = DateTime.Now;
                            dtpCheckOut.Value = DateTime.Now;
                            cmbPagamento.SelectedIndex = 0;
                            cmbSelecionarChale.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show(retorno.Mensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show
                        (
                            $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Registrar nova reserva"
                        );
                    }
                }
            }
        }

        private void btnBuscarCPF_Click(object sender, EventArgs e)
        {
            if (txtCPFBusca.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe o CPF do hospede.");
            }
            else
            {
                try
                {
                    var busca = _hospedeBusiness.Obter(txtCPFBusca.Text);

                    if (busca == null)
                    {
                        MessageBox.Show("Não foi encontrado nenhum hóspede para o CPF informado.");

                        txtCPFBusca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Hóspede encontrado.");

                        Hospede = busca;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show
                    (
                        $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Registrar nova reserva"
                    );
                }
            }
        }

        private void txtCPFBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscarCPF_Click(btnBuscarCPF, new EventArgs());
            }
        }
    }
}
