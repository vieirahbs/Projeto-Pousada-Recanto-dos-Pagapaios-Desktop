
namespace RecantoDosPapagaios
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlTopoUsuario = new System.Windows.Forms.Panel();
            this.btnHideMenu = new System.Windows.Forms.Button();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnChales = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnHospede = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlConteudo.SuspendLayout();
            this.pnlTopoUsuario.SuspendLayout();
            this.pnlMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.pnlTopoUsuario);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(167, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(672, 486);
            this.pnlConteudo.TabIndex = 2;
            // 
            // pnlTopoUsuario
            // 
            this.pnlTopoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTopoUsuario.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.PanelContentTop;
            this.pnlTopoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTopoUsuario.Controls.Add(this.btnHideMenu);
            this.pnlTopoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopoUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlTopoUsuario.Name = "pnlTopoUsuario";
            this.pnlTopoUsuario.Size = new System.Drawing.Size(672, 57);
            this.pnlTopoUsuario.TabIndex = 0;
            // 
            // btnHideMenu
            // 
            this.btnHideMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnHideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHideMenu.BackgroundImage")));
            this.btnHideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideMenu.FlatAppearance.BorderSize = 0;
            this.btnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMenu.Location = new System.Drawing.Point(6, 4);
            this.btnHideMenu.Name = "btnHideMenu";
            this.btnHideMenu.Size = new System.Drawing.Size(32, 34);
            this.btnHideMenu.TabIndex = 0;
            this.btnHideMenu.UseVisualStyleBackColor = false;
            this.btnHideMenu.Click += new System.EventHandler(this.btnHideMenu_Click_1);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuPrincipal.Controls.Add(this.btnAlertas);
            this.pnlMenuPrincipal.Controls.Add(this.pnlLogo);
            this.pnlMenuPrincipal.Controls.Add(this.btnGraficos);
            this.pnlMenuPrincipal.Controls.Add(this.btnRelatorios);
            this.pnlMenuPrincipal.Controls.Add(this.btnFuncionarios);
            this.pnlMenuPrincipal.Controls.Add(this.btnChales);
            this.pnlMenuPrincipal.Controls.Add(this.btnCheckOut);
            this.pnlMenuPrincipal.Controls.Add(this.btnCheckIn);
            this.pnlMenuPrincipal.Controls.Add(this.btnReservas);
            this.pnlMenuPrincipal.Controls.Add(this.btnHospede);
            this.pnlMenuPrincipal.Controls.Add(this.btnHome);
            this.pnlMenuPrincipal.Controls.Add(this.lblMenuPrincipal);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(167, 486);
            this.pnlMenuPrincipal.TabIndex = 1;
            // 
            // btnAlertas
            // 
            this.btnAlertas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlertas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertas.ForeColor = System.Drawing.Color.White;
            this.btnAlertas.Image = global::RecantoDosPapagaios.Properties.Resources.Alertas20;
            this.btnAlertas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlertas.Location = new System.Drawing.Point(20, 451);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(132, 35);
            this.btnAlertas.TabIndex = 19;
            this.btnAlertas.Text = "       Alertas";
            this.btnAlertas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertas.UseVisualStyleBackColor = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGraficos.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.White;
            this.btnGraficos.Image = global::RecantoDosPapagaios.Properties.Resources.Graphics20;
            this.btnGraficos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGraficos.Location = new System.Drawing.Point(21, 414);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(132, 35);
            this.btnGraficos.TabIndex = 18;
            this.btnGraficos.Text = "      Gráficos";
            this.btnGraficos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.UseVisualStyleBackColor = false;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = global::RecantoDosPapagaios.Properties.Resources.Relatiorios2_20;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(20, 376);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(132, 35);
            this.btnRelatorios.TabIndex = 17;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = global::RecantoDosPapagaios.Properties.Resources.Funcionario;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(21, 339);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(132, 35);
            this.btnFuncionarios.TabIndex = 16;
            this.btnFuncionarios.Text = "   Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnChales
            // 
            this.btnChales.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChales.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnChales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChales.ForeColor = System.Drawing.Color.White;
            this.btnChales.Image = global::RecantoDosPapagaios.Properties.Resources.Chales;
            this.btnChales.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnChales.Location = new System.Drawing.Point(23, 298);
            this.btnChales.Name = "btnChales";
            this.btnChales.Size = new System.Drawing.Size(132, 35);
            this.btnChales.TabIndex = 15;
            this.btnChales.Text = "      Chalés";
            this.btnChales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChales.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(23, 257);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 35);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "      Check-Out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Image = global::RecantoDosPapagaios.Properties.Resources.DoorCheckIn1;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCheckIn.Location = new System.Drawing.Point(23, 216);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(132, 35);
            this.btnCheckIn.TabIndex = 13;
            this.btnCheckIn.Text = "      Check-In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = global::RecantoDosPapagaios.Properties.Resources.Reservas20;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReservas.Location = new System.Drawing.Point(25, 176);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(132, 35);
            this.btnReservas.TabIndex = 12;
            this.btnReservas.Text = "      Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnHospede
            // 
            this.btnHospede.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHospede.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospede.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospede.ForeColor = System.Drawing.Color.White;
            this.btnHospede.Image = global::RecantoDosPapagaios.Properties.Resources.Usuario20;
            this.btnHospede.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHospede.Location = new System.Drawing.Point(25, 136);
            this.btnHospede.Name = "btnHospede";
            this.btnHospede.Size = new System.Drawing.Size(117, 35);
            this.btnHospede.TabIndex = 11;
            this.btnHospede.Text = "      Hóspede";
            this.btnHospede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospede.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::RecantoDosPapagaios.Properties.Resources.Home20;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(27, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(132, 35);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "      Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(21, 64);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(118, 16);
            this.lblMenuPrincipal.TabIndex = 5;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.PanelMenuPrincipalTop;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(163, 55);
            this.pnlLogo.TabIndex = 0;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmTelaPrincipal";
            this.Text = "Recanto dos papagaios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlTopoUsuario.ResumeLayout(false);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHospede;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnChales;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnAlertas;
        private System.Windows.Forms.Panel pnlTopoUsuario;
        private System.Windows.Forms.Button btnHideMenu;
    }
}