using System;
using System.Windows.Forms;
using RecantoDosPapagaios.TelasPrincipais;
using RecantoDosPapagaios.TelasDeUsuarios;
using RecantoDosPapagaios.Json;

namespace RecantoDosPapagaios
{
    public partial class frmTelaPrincipal : Form
    {
        private Form objForm;

        public FuncionarioGetJson Funcionario { get; set; }

        public int IdFuncionario { get; set; }

        public string NomeDeUsuario { get; set; }

        public string Senha { get; set; }

        public frmTelaPrincipal(FuncionarioGetJson funcionario)
        {
            InitializeComponent();

            nomeDoUsuarioToolStripMenuItem.Text = NomeDeUsuario;

            Funcionario = funcionario;
        }

        public frmTelaPrincipal()
        {
            InitializeComponent();

            nomeDoUsuarioToolStripMenuItem.Text = NomeDeUsuario;
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            #region Codigo

            //Estabelce a cor de fundo dos botões assim que o frmPricipal é aberto.
            //Dessa forma, ao clicar no botão seguinte, o anterior volta a cor original.
            btnHome.BackColor = System.Drawing.Color.LightSeaGreen;
            btnHospede.BackColor = System.Drawing.Color.LightSeaGreen;
            btnReservas.BackColor = System.Drawing.Color.LightSeaGreen;
            btnCheckIn.BackColor = System.Drawing.Color.LightSeaGreen;
            btnCheckOut.BackColor = System.Drawing.Color.LightSeaGreen;
            btnChales.BackColor = System.Drawing.Color.LightSeaGreen;
            btnFuncionarios.BackColor = System.Drawing.Color.LightSeaGreen;
            btnRelatorios.BackColor = System.Drawing.Color.LightSeaGreen;
            btnGraficos.BackColor = System.Drawing.Color.LightSeaGreen;
            btnAlertas.BackColor = System.Drawing.Color.LightSeaGreen;

            objForm?.Close();
            objForm = new frmHome(IdFuncionario);

            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(objForm);
            objForm.Show();

            #endregion Codigo

            nomeDoUsuarioToolStripMenuItem.Text = NomeDeUsuario;
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReduzirTamanhoDoMenu(Button btn, int posicaoA, int posicaoB)
        {
            #region Codigo
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

            #endregion Codigo
        }

        private void AumentarTamanhoDoMenu(Button btn, string txt, int posicaoA, int posicaoB)
        {
            #region Codigo

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

            #endregion Codigo
        }

        private void btnHideMenu_Click_1(object sender, EventArgs e)
        {
            #region Codigo

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

                pnlConteudo.Dock = DockStyle.Fill;
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

            #endregion Codigo
        }

        #region Eventos click dos botões da tela principal
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmHome(IdFuncionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnHome.BackColor = System.Drawing.Color.DarkCyan;
            objForm.Show();
        }

        private void btnHospede_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmHospede(IdFuncionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnHospede.BackColor = System.Drawing.Color.DarkCyan;
            objForm.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmReservas(IdFuncionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnReservas.BackColor = System.Drawing.Color.DarkCyan;
            objForm.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmCheckIn(IdFuncionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnCheckIn.BackColor = System.Drawing.Color.DarkCyan;

            objForm.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmCheckOut(IdFuncionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnCheckOut.BackColor = System.Drawing.Color.DarkCyan;
            objForm.Show();
        }

        private void btnChales_Click(object sender, EventArgs e)
        {
            if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
            {
                MessageBox.Show("Acesso negado a essa funcionalidade.", "Restrição de acesso");
            }
            else
            {
                frmTelaPrincipal_Load(this, new EventArgs());
                objForm?.Close();
                objForm = new frmChales(IdFuncionario)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                pnlConteudo.Controls.Add(objForm);
                btnChales.BackColor = System.Drawing.Color.DarkCyan;
                objForm.Show();
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
            {
                MessageBox.Show("Acesso negado a essa funcionalidade.", "Restrição de acesso");
            }
            else
            {
                frmTelaPrincipal_Load(this, new EventArgs());
                objForm?.Close();
                objForm = new frmFuncionarios(IdFuncionario)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                pnlConteudo.Controls.Add(objForm);
                btnFuncionarios.BackColor = System.Drawing.Color.DarkCyan;
                objForm.Show();
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
            {
                MessageBox.Show("Acesso negado a essa funcionalidade.", "Restrição de acesso");
            }
            else
            {
                frmTelaPrincipal_Load(this, new EventArgs());
                objForm?.Close();
                objForm = new frmRelatorios(IdFuncionario)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                pnlConteudo.Controls.Add(objForm);
                btnRelatorios.BackColor = System.Drawing.Color.DarkCyan;
                objForm.Show();
            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
            {
                MessageBox.Show("Acesso negado a essa funcionalidade.", "Restrição de acesso");
            }
            else
            {
                frmTelaPrincipal_Load(this, new EventArgs());
                objForm?.Close();
                objForm = new frmGraficos(IdFuncionario)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                pnlConteudo.Controls.Add(objForm);
                btnGraficos.BackColor = System.Drawing.Color.DarkCyan;
                objForm.Show();
            }

        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmAlertas(IdFuncionario, Funcionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            btnAlertas.BackColor = System.Drawing.Color.DarkCyan;
            objForm.Show();
        }

        #endregion

        #region Eventos dos botões do menu de usuário
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmMinhaConta(IdFuncionario, Senha, false, Funcionario)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            objForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTelaDeLogin fTelaDeLogin = new frmTelaDeLogin();
            fTelaDeLogin.Show();
            this.Hide();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal_Load(this, new EventArgs());
            objForm?.Close();
            objForm = new frmAjuda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlConteudo.Controls.Add(objForm);
            objForm.Show();
        }
        #endregion
    }
}
