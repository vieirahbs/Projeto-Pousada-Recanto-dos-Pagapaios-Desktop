using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecantoDosPapagaios
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {

        }
        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHideMenu_Click(object sender, EventArgs e)
        {

        }

        private void ReduzirTamanhoDoMenu(Button btn, int posicaoA, int posicaoB)
        {
            lblMenuPrincipal.Text = string.Empty;
            //Alteração do tamanho do menu:
            pnlLogo.BackgroundImage = Properties.Resources.PanelMenuPrincipalTopCrop;
            pnlMenuPrincipal.Size = new System.Drawing.Size(62, 486);

            btn.Text = string.Empty;
            btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btn.Size = new System.Drawing.Size(35, 35);
            btn.Location = new System.Drawing.Point(posicaoA, posicaoB);
            btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        }

        private void AumentarTamanhoDoMenu(Button btn, string txt,int posicaoA, int posicaoB)
        {
            lblMenuPrincipal.Text = "MENU PRINCIPAL";
            //Alteração do tamanho do menu:
            pnlLogo.BackgroundImage = Properties.Resources.PanelMenuPrincipalTop;
            pnlMenuPrincipal.Size = new System.Drawing.Size(167, 486);

            btn.Text = txt;
            btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btn.Size = new System.Drawing.Size(132, 35);
            btn.Location = new System.Drawing.Point(posicaoA, posicaoB);
            btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top 
                | System.Windows.Forms.AnchorStyles.Left))));
        }

        private void btnHideMenu_Click_1(object sender, EventArgs e)
        {
            if (pnlMenuPrincipal.Size.Width == 167)
            {
                ReduzirTamanhoDoMenu(btnHome, 11, 95);
                ReduzirTamanhoDoMenu(btnHospede, 11, 136);
                ReduzirTamanhoDoMenu(btnReservas, 11, 176);
                ReduzirTamanhoDoMenu(btnCheckIn, 11, 216);
                ReduzirTamanhoDoMenu(btnCheckOut, 11, 257);
                ReduzirTamanhoDoMenu(btnChales, 11, 298);
                ReduzirTamanhoDoMenu(btnFuncionarios, 11, 339);
                ReduzirTamanhoDoMenu(btnRelatorios, 11, 376);
                ReduzirTamanhoDoMenu(btnGraficos, 11, 414);
                ReduzirTamanhoDoMenu(btnAlertas, 11, 451);
            }
            else if (pnlMenuPrincipal.Size.Width == 62)
            {
                AumentarTamanhoDoMenu(btnHome, "      Home", 27, 95);
                AumentarTamanhoDoMenu(btnHospede, "      Hospede", 25, 136);
                AumentarTamanhoDoMenu(btnReservas, "      Reservas", 23, 176);
                AumentarTamanhoDoMenu(btnCheckIn, "      Check-In", 23, 216);
                AumentarTamanhoDoMenu(btnCheckOut, "      Check-Out", 23, 257);
                AumentarTamanhoDoMenu(btnChales, "      Chales", 23, 298);
                AumentarTamanhoDoMenu(btnFuncionarios, "    Funcionários", 21, 339);
                AumentarTamanhoDoMenu(btnRelatorios, " Relatórios", 20, 376);
                AumentarTamanhoDoMenu(btnGraficos, "       Gráficos", 21, 414);
                AumentarTamanhoDoMenu(btnAlertas, "       Alertas", 21, 451);
            }
        }
    }
}
