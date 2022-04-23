using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json.ChaleJson;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmChaleDetalhes : Form
    {
        private readonly ChaleBusiness _chaleBusiness;

        private readonly ReservaBusiness _reservaBusiness;

        public AcomodacaoUnitariaJsonGet ProximasReservas { get; set; }

        public int idFuncionario { get; set; }

        public int idChale { get; set; }

        public frmChaleDetalhes(int id)
        {
            InitializeComponent();

            _chaleBusiness = new ChaleBusiness();

            _reservaBusiness = new ReservaBusiness();

            idChale = id;
        }

        public frmChaleDetalhes() { }

        private void frmChaleDetalhes_Load(object sender, EventArgs e)
        {
            lstHistoricoChale.Clear();
            lstHistoricoChale.Columns.Insert(0, "Código da Reserva", 120, HorizontalAlignment.Left);
            lstHistoricoChale.Columns.Insert(1, "Titular", 120, HorizontalAlignment.Left);
            lstHistoricoChale.Columns.Insert(2, "Check-in", 140, HorizontalAlignment.Left);
            lstHistoricoChale.Columns.Insert(3, "Check-out", 140, HorizontalAlignment.Left);

            try
            {
                var proximasReservas = _chaleBusiness.Obter(idChale);

                ProximasReservas = proximasReservas;

                if (proximasReservas.ProximasReservas != null)
                {
                    foreach (ReservaResumidaGetJson reserva in proximasReservas.ProximasReservas)
                    {
                        ListViewItem reservaTeste = lstHistoricoChale.Items.Add(reserva.idReserva.ToString());
                        reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, reserva.Hospede.NomeCompleto));
                        reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, reserva.DataCheckIn.ToString("dd/MM/yyyy")));
                        reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, reserva.DataCheckOut.ToString("dd/MM/yyyy")));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as próximas reservas desse chalé.", "Detalhes do chalé");
            }
        }

        private void lstHistoricoChale_DoubleClick(object sender, EventArgs e)
        {
            frmReservaDetalhe fReservaDetalhe = new frmReservaDetalhe(idFuncionario);

            var idReservaSelecionada = 0;

            for (int c = 0; ProximasReservas.ProximasReservas.Count > c; c++)
            {
                if (lstHistoricoChale.SelectedItems[0].Text.Equals(ProximasReservas.ProximasReservas[c].idReserva.ToString()))
                {
                    idReservaSelecionada = ProximasReservas.ProximasReservas[c].idReserva;
                }
            }

            try
            {
                var reserva = _reservaBusiness.Get(idReservaSelecionada);

                if (reserva != null)
                {
                    fReservaDetalhe.Reserva = reserva;

                    #region Adiciona a imagem do chalé
                    if (reserva.Acomodacao.Id.Equals(1))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
                    }
                    else if (reserva.Acomodacao.Id.Equals(2))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale2;
                    }
                    else if (reserva.Acomodacao.Id.Equals(3))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale3;
                    }
                    else if (reserva.Acomodacao.Id.Equals(4))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale4;
                    }
                    else if (reserva.Acomodacao.Id.Equals(5))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale5;
                    }
                    else if (reserva.Acomodacao.Id.Equals(6))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale6;
                    }
                    else if (reserva.Acomodacao.Id.Equals(7))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale7;
                    }
                    else if (reserva.Acomodacao.Id.Equals(8))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale8;
                    }
                    else if (reserva.Acomodacao.Id.Equals(9))
                    {
                        fReservaDetalhe.pcbChale.Image = global::RecantoDosPapagaios.Properties.Resources.Chale9;
                    }
                    else if (reserva.Acomodacao.Id.Equals(10))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale10;
                    }
                    #endregion
                    fReservaDetalhe.IdReserva = reserva.Id;
                    fReservaDetalhe.Categoria = reserva.Acomodacao.StatusAcomodacao.Descricao;
                    fReservaDetalhe.pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    fReservaDetalhe.lblStatusReserva.Text = reserva.StatusReserva.Descricao;
                    fReservaDetalhe.txtReservaDetalhes.Text = AdicionarDetalhesReserva(reserva);
                    fReservaDetalhe.lblValorDiaria.Text = "R$ " + reserva.PrecoUnitario.ToString("F2");
                    fReservaDetalhe.lblValorTotal.Text = "R$ " + reserva.PrecoTotal.ToString("F2");
                    fReservaDetalhe.lblCodigoReserva.Text = reserva.Id.ToString();

                    if (reserva.StatusReserva.Descricao.Trim().Equals("Iniciada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.SteelBlue;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = true;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                    }
                    else if (reserva.StatusReserva.Descricao.Trim().Equals("Confirmada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.Chocolate;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = true;
                    }
                    else if (reserva.StatusReserva.Descricao.Trim().Equals("Concluída"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.DarkCyan;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                    }
                    else if (reserva.StatusReserva.Descricao.Trim().Equals("Cancelada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.DimGray;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                    }

                    fReservaDetalhe.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Detalhes do chalé"
                );
            }
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
    }
}
