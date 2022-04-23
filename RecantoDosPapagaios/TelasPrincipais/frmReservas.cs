using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.TelasSecundarias;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmReservas : Form
    {
        private readonly ReservaBusiness _reservaBusiness;

        public int idFuncionario { get; set; }

        public List<Reserva> Reservas;

        public frmReservas(int id)
        {
            InitializeComponent();

            _reservaBusiness = new ReservaBusiness();

            idFuncionario = id;
        }

        public frmReservas() { }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            lstReservas.Clear();
            lstReservas.Columns.Insert(0, "Codigo de reserva", 100, HorizontalAlignment.Left);
            lstReservas.Columns.Insert(1, "Status", 80, HorizontalAlignment.Left);
            lstReservas.Columns.Insert(2, "Titular", 200, HorizontalAlignment.Left);
            lstReservas.Columns.Insert(3, "Chalé", 140, HorizontalAlignment.Left);
            lstReservas.Columns.Insert(4, "Check-in", 80, HorizontalAlignment.Left);
            lstReservas.Columns.Insert(5, "Check-out", 80, HorizontalAlignment.Left);

        }

        private void btnBuscarReservas_Click(object sender, EventArgs e)
        {
            try
            {
                frmReservas_Load(this, new EventArgs());
                
                int count = 0;

                if (!txtPesquisaReserva.Text.Trim().Equals(string.Empty))
                {
                    var reserva = _reservaBusiness.Obter(txtPesquisaReserva.Text);

                    Reservas = reserva;

                    if (reserva != null)
                    {
                        foreach (Reserva item in reserva)
                        {
                            ListViewItem reservaTeste = lstReservas.Items.Add(item.Id.ToString());
                            reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.StatusReserva.Descricao));
                            reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                            reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                            reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                            reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));

                            count++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF não localizado.", "Reservas");
                    }
                }              
                
                lblTotalReserva.Text = "Total de reservas localizadas: " + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Reservas"
                );
            }
        }

        private void btnCriarNovaReserva_Click(object sender, EventArgs e)
        {
            frmCriarNovaReserva fCriarNovaReserva = new frmCriarNovaReserva();
            fCriarNovaReserva.Show();
        }

        private void lstReservas_DoubleClick(object sender, EventArgs e)
        {
            frmReservaDetalhe fReservaDetalhe = new frmReservaDetalhe(idFuncionario);
            
            foreach (Reserva item in Reservas)
            {
                if (item.Id.ToString() == lstReservas.SelectedItems[0].Text)
                {
                    fReservaDetalhe.Reserva = item;

                    #region Adiciona a imagem do chalé
                    if (item.Acomodacao.Id.Equals(1))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
                    }
                    else if (item.Acomodacao.Id.Equals(2))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale2;
                    }
                    else if (item.Acomodacao.Id.Equals(3))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale3;
                    }
                    else if (item.Acomodacao.Id.Equals(4))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale4;
                    }
                    else if (item.Acomodacao.Id.Equals(5))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale5;
                    }
                    else if (item.Acomodacao.Id.Equals(6))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale6;
                    }
                    else if (item.Acomodacao.Id.Equals(7))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale7;
                    }
                    else if (item.Acomodacao.Id.Equals(8))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale8;
                    }
                    else if (item.Acomodacao.Id.Equals(9))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale9;
                    }
                    else if (item.Acomodacao.Id.Equals(10))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale10;
                    }
                    #endregion
                    fReservaDetalhe.IdReserva = item.Id;
                    fReservaDetalhe.Categoria = item.Acomodacao.StatusAcomodacao.Descricao;
                    fReservaDetalhe.pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    fReservaDetalhe.lblStatusReserva.Text = item.StatusReserva.Descricao;
                    fReservaDetalhe.txtReservaDetalhes.Text = AdicionarDetalhesReserva(item);
                    fReservaDetalhe.lblValorDiaria.Text = "R$ " + item.PrecoUnitario.ToString("F2");
                    fReservaDetalhe.lblValorTotal.Text = "R$ " + item.PrecoTotal.ToString("F2");
                    fReservaDetalhe.lblCodigoReserva.Text = item.Id.ToString();

                    if (item.StatusReserva.Descricao.Trim().Equals("Iniciada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.SteelBlue;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = true;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                    }
                    else if (item.StatusReserva.Descricao.Trim().Equals("Confirmada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.Chocolate;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = true;
                    }
                    else if (item.StatusReserva.Descricao.Trim().Equals("Concluída"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.DarkCyan;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                    }
                    else if (item.StatusReserva.Descricao.Trim().Equals("Cancelada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.IndianRed;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                    }
                }
            }

            fReservaDetalhe.Show();
        }

        private void txtPesquisaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscarReservas_Click(btnBuscarReservas, new EventArgs());
            }
        }

        #region botões de filtro de reservas
        private void btnFinalizadas_Click(object sender, EventArgs e)
        {
            if (lstReservas.Items.Count.Equals(0))
            {
                MessageBox.Show("Antes, informe um CPF e clique em pesquisar reservas para poder filtrar.", "Reservas");
                return;
            }

            frmReservas_Load(this, new EventArgs());
            
            int count = 0;

            foreach (Reserva item in Reservas)
            {
                if (item.StatusReserva.Descricao.Equals("Concluída"))
                {
                    ListViewItem reservaTeste = lstReservas.Items.Add(item.Id.ToString());
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.StatusReserva.Descricao));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));
                    
                    count++;
                }
            }

            lblTotalReserva.Text = "Total de reservas localizadas: " + count.ToString();
        }

        private void btnCanceladas_Click(object sender, EventArgs e)
        {
            if (lstReservas.Items.Count.Equals(0))
            {
                MessageBox.Show("Antes, informe um CPF e clique em pesquisar reservas para poder filtrar.", "Reservas");
                return;
            }

            frmReservas_Load(this, new EventArgs());
            
            int count = 0;

            foreach (Reserva item in Reservas)
            {
                if (item.StatusReserva.Descricao.Equals("Cancelada"))
                {
                    ListViewItem reservaTeste = lstReservas.Items.Add(item.Id.ToString());
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.StatusReserva.Descricao));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));
                    
                    count++;
                }
            }

            lblTotalReserva.Text = "Total de reservas localizadas: " + count.ToString();
        }

        private string AdicionarDetalhesReserva(Reserva reserva)
        {
            var builder = new StringBuilder();
            builder.Append("Hóspede: " + reserva.Hospede.NomeCompleto);
            builder.Append(Environment.NewLine);
            
            builder.Append("Chalé: " + reserva.Acomodacao.Nome);
            builder.Append(Environment.NewLine);
            
            builder.Append("Tipo de pagamento: " + reserva.Pagamento.TipoPagamento.Descricao);
            builder.Append(Environment.NewLine);
            
            builder.Append("Status: " + reserva.Pagamento.StatusPagamento.Descricao);
            builder.Append(Environment.NewLine);

            builder.Append("Data de check-in: " + reserva.DataCheckIn.ToString("d"));
            builder.Append(Environment.NewLine);

            builder.Append("Data de check-out: " + reserva.DataCheckOut.ToString("d"));
            builder.Append(Environment.NewLine);

            builder.Append("Acompanhantes: " + reserva.Acompanhantes.ToString());
            builder.Append(Environment.NewLine);

            return builder.ToString();
        }

        private void btnIniciadas_Click(object sender, EventArgs e)
        {
            if (lstReservas.Items.Count.Equals(0))
            {
                MessageBox.Show("Antes, informe um CPF e clique em pesquisar reservas para poder filtrar.", "Reservas");
                return;
            }

            frmReservas_Load(this, new EventArgs());
            
            int count = 0;

            foreach (Reserva item in Reservas)
            {
                if (item.StatusReserva.Descricao.Equals("Iniciada"))
                {
                    ListViewItem reservaTeste = lstReservas.Items.Add(item.Id.ToString());
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.StatusReserva.Descricao));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));
                    
                    count++;
                }
            }

            lblTotalReserva.Text = "Total de reservas localizadas: " + count.ToString();
        }

        private void btnConfirmadas_Click(object sender, EventArgs e)
        {
            if (lstReservas.Items.Count.Equals(0))
            {
                MessageBox.Show("Antes, informe um CPF e clique em pesquisar reservas para poder filtrar.", "Reservas");
                return;
            }

            frmReservas_Load(this, new EventArgs());

            int count = 0;

            foreach (Reserva item in Reservas)
            {
                if (item.StatusReserva.Descricao.Equals("Confirmada"))
                {
                    ListViewItem reservaTeste = lstReservas.Items.Add(item.Id.ToString());
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.StatusReserva.Descricao));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                    reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));

                    count++;
                }
            }

            lblTotalReserva.Text = "Total de reservas localizadas: " + count.ToString();
        }
        #endregion
    }
}
