using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmFazerCheckIn : Form
    {
        private readonly CheckInBusiness _checkInBusiness;

        public int idFuncionario { get; set; }
        public int IdAcomodacao { get; set; }

        public Reserva Reserva { get; set; }

        public frmFazerCheckIn(int id, int idAcomodacao)
        {
            InitializeComponent();

            idFuncionario = id;
            IdAcomodacao = idAcomodacao;

            _checkInBusiness = new CheckInBusiness();
        }

        private void frmFazerCheckIn_Load(object sender, EventArgs e)
        {
            #region Adiciona foto do chalé
            if (IdAcomodacao.Equals(1))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(2))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale2;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(3))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale3;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(4))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale4;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(5))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale5;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(6))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale6;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(7))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale7;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(8))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale8;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(9))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale9;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(10))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale10;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            #endregion
        }

        private void btnFazerCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                var fazerCheckIn = _checkInBusiness.FazerCheckIn(Reserva.Id, idFuncionario);

                if (fazerCheckIn.Mensagem != null)
                {
                    MessageBox.Show(fazerCheckIn.Mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Check-in"
                );
            }
        }

    }
}
