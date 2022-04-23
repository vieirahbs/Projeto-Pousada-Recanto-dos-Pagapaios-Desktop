using System;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmReservaDetalhe : Form
    {
        private readonly ReservaBusiness _reservaBusiness;

        public int idFuncionario { get; set; }
        public int IdReserva { get; set; }
        public string Categoria { get; set; }

        public Reserva Reserva { get; set; }

        public frmReservaDetalhe(int id)
        {
            InitializeComponent();

            idFuncionario = id;
            _reservaBusiness = new ReservaBusiness();
        }

        private void frmReservaDetalhe_Load(object sender, EventArgs e)
        {
            if (Categoria != "Ocupado")
            {
                btnCancelarReservar.Enabled = false;
                btnCancelarReservar.Visible = false;
            }
        }

        public frmReservaDetalhe() 
        {
            _reservaBusiness = new ReservaBusiness();
        }

        private void btnFazerCheckIn_Click(object sender, EventArgs e)
        {
            frmFazerCheckIn fFazerCheckIn = new frmFazerCheckIn(idFuncionario, Reserva.Acomodacao.Id);
            
            fFazerCheckIn.lblTituloNumeroReserva.Text = "Reserva #" + Reserva.Id.ToString(); ;
            fFazerCheckIn.lblNomeTitular.Text = Reserva.Hospede.NomeCompleto;
            fFazerCheckIn.lblCheckInData.Text = Reserva.DataCheckIn.ToString("dd/MM/yyyy, dddd");
            fFazerCheckIn.lblCheckOutData.Text = Reserva.DataCheckOut.ToString("dd/MM/yyyy, dddd");
            fFazerCheckIn.lblAcompanhantes.Text = Reserva.Acompanhantes.ToString();
            fFazerCheckIn.lblPagamento.Text = Reserva.Pagamento.TipoPagamento.Descricao;
            fFazerCheckIn.lblValorDiaria.Text = "R$ " + Reserva.PrecoUnitario.ToString("F2");
            fFazerCheckIn.lblValorTotal.Text = "R$ " + Reserva.PrecoTotal.ToString("F2");

            fFazerCheckIn.Reserva = Reserva;

            fFazerCheckIn.Show();
            this.Close();
        }

        private void btnFazerCheckOut_Click(object sender, EventArgs e)
        {
            frmFazerCheckOut fFazerCheckOut = new frmFazerCheckOut(idFuncionario, Reserva.Acomodacao.Id);
                        
            fFazerCheckOut.lblTituloNumeroReserva.Text = "Reserva #" + Reserva.Id.ToString();
            fFazerCheckOut.lblNomeTitular.Text = Reserva.Hospede.NomeCompleto;
            fFazerCheckOut.lblCheckInData.Text = Reserva.DataCheckIn.ToString("dd/MM/yyyy, dddd");
            fFazerCheckOut.lblCheckOutData.Text = Reserva.DataCheckOut.ToString("dd/MM/yyyy, dddd");
            fFazerCheckOut.lblAcompanhantes.Text = Reserva.Acompanhantes.ToString();
            fFazerCheckOut.lblValorDiaria.Text = Reserva.PrecoUnitario.ToString("F2");
            fFazerCheckOut.lblValorTotal.Text = Reserva.PrecoTotal.ToString("F2");

            fFazerCheckOut.Reserva = Reserva;

            fFazerCheckOut.Show();
            this.Close();
        }

        private void btnCancelarReservar_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem certeza que deseja cancelar esta reserva?";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, "Detalhes de reserva", botoes);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    var retorno = _reservaBusiness.Excluir(IdReserva);

                    if (retorno.StatusCode.Equals(200))
                    {
                        MessageBox.Show(retorno.Mensagem, "Detalhes de reserva");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(retorno.Mensagem, "Detalhes de reserva");
                    }
                }
                catch (ErrorException ex)
                {
                    MessageBox.Show(ex.Message, "Detalhes de reserva");
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Detalhes de reserva");
                }
            }

        }

    }
}
