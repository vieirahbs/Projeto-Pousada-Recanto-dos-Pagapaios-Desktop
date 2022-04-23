
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmadas = new System.Windows.Forms.Button();
            this.btnIniciadas = new System.Windows.Forms.Button();
            this.btnCanceladas = new System.Windows.Forms.Button();
            this.lstReservas = new System.Windows.Forms.ListView();
            this.btnFinalizadas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaReserva = new System.Windows.Forms.TextBox();
            this.btnBuscarReservas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarNovaReserva = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotalReserva = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnConfirmadas);
            this.panel2.Controls.Add(this.btnIniciadas);
            this.panel2.Controls.Add(this.btnCanceladas);
            this.panel2.Controls.Add(this.lstReservas);
            this.panel2.Controls.Add(this.btnFinalizadas);
            this.panel2.Location = new System.Drawing.Point(108, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 278);
            this.panel2.TabIndex = 40;
            // 
            // btnConfirmadas
            // 
            this.btnConfirmadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmadas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmadas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirmadas.FlatAppearance.BorderSize = 0;
            this.btnConfirmadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmadas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmadas.ForeColor = System.Drawing.Color.White;
            this.btnConfirmadas.Location = new System.Drawing.Point(274, 3);
            this.btnConfirmadas.Name = "btnConfirmadas";
            this.btnConfirmadas.Size = new System.Drawing.Size(128, 24);
            this.btnConfirmadas.TabIndex = 49;
            this.btnConfirmadas.Text = "Ver confirmadas";
            this.btnConfirmadas.UseVisualStyleBackColor = false;
            this.btnConfirmadas.Click += new System.EventHandler(this.btnConfirmadas_Click);
            // 
            // btnIniciadas
            // 
            this.btnIniciadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciadas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciadas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciadas.FlatAppearance.BorderSize = 0;
            this.btnIniciadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciadas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciadas.ForeColor = System.Drawing.Color.White;
            this.btnIniciadas.Location = new System.Drawing.Point(417, 3);
            this.btnIniciadas.Name = "btnIniciadas";
            this.btnIniciadas.Size = new System.Drawing.Size(113, 24);
            this.btnIniciadas.TabIndex = 48;
            this.btnIniciadas.Text = "Ver iniciadas";
            this.btnIniciadas.UseVisualStyleBackColor = false;
            this.btnIniciadas.Click += new System.EventHandler(this.btnIniciadas_Click);
            // 
            // btnCanceladas
            // 
            this.btnCanceladas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCanceladas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCanceladas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCanceladas.FlatAppearance.BorderSize = 0;
            this.btnCanceladas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanceladas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceladas.ForeColor = System.Drawing.Color.White;
            this.btnCanceladas.Location = new System.Drawing.Point(668, 3);
            this.btnCanceladas.Name = "btnCanceladas";
            this.btnCanceladas.Size = new System.Drawing.Size(113, 24);
            this.btnCanceladas.TabIndex = 47;
            this.btnCanceladas.Text = "Ver canceladas";
            this.btnCanceladas.UseVisualStyleBackColor = false;
            this.btnCanceladas.Click += new System.EventHandler(this.btnCanceladas_Click);
            // 
            // lstReservas
            // 
            this.lstReservas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstReservas.FullRowSelect = true;
            this.lstReservas.GridLines = true;
            this.lstReservas.HideSelection = false;
            this.lstReservas.HoverSelection = true;
            this.lstReservas.Location = new System.Drawing.Point(30, 33);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(750, 215);
            this.lstReservas.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstReservas.TabIndex = 0;
            this.lstReservas.UseCompatibleStateImageBehavior = false;
            this.lstReservas.View = System.Windows.Forms.View.Details;
            this.lstReservas.DoubleClick += new System.EventHandler(this.lstReservas_DoubleClick);
            // 
            // btnFinalizadas
            // 
            this.btnFinalizadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizadas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinalizadas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnFinalizadas.FlatAppearance.BorderSize = 0;
            this.btnFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizadas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizadas.ForeColor = System.Drawing.Color.White;
            this.btnFinalizadas.Location = new System.Drawing.Point(543, 3);
            this.btnFinalizadas.Name = "btnFinalizadas";
            this.btnFinalizadas.Size = new System.Drawing.Size(113, 24);
            this.btnFinalizadas.TabIndex = 38;
            this.btnFinalizadas.Text = "Ver concluídas";
            this.btnFinalizadas.UseVisualStyleBackColor = false;
            this.btnFinalizadas.Click += new System.EventHandler(this.btnFinalizadas_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.LegendaBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPesquisaReserva);
            this.panel1.Controls.Add(this.btnBuscarReservas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(101, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 84);
            this.panel1.TabIndex = 39;
            // 
            // txtPesquisaReserva
            // 
            this.txtPesquisaReserva.Location = new System.Drawing.Point(169, 25);
            this.txtPesquisaReserva.Name = "txtPesquisaReserva";
            this.txtPesquisaReserva.Size = new System.Drawing.Size(526, 20);
            this.txtPesquisaReserva.TabIndex = 37;
            this.txtPesquisaReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaReserva_KeyPress);
            // 
            // btnBuscarReservas
            // 
            this.btnBuscarReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarReservas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarReservas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReservas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReservas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReservas.Location = new System.Drawing.Point(715, 19);
            this.btnBuscarReservas.Name = "btnBuscarReservas";
            this.btnBuscarReservas.Size = new System.Drawing.Size(79, 30);
            this.btnBuscarReservas.TabIndex = 36;
            this.btnBuscarReservas.Text = "Buscar";
            this.btnBuscarReservas.UseVisualStyleBackColor = false;
            this.btnBuscarReservas.Click += new System.EventHandler(this.btnBuscarReservas_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filtrar por CPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCriarNovaReserva
            // 
            this.btnCriarNovaReserva.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarNovaReserva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovaReserva.ForeColor = System.Drawing.Color.White;
            this.btnCriarNovaReserva.Location = new System.Drawing.Point(725, 119);
            this.btnCriarNovaReserva.Name = "btnCriarNovaReserva";
            this.btnCriarNovaReserva.Size = new System.Drawing.Size(182, 37);
            this.btnCriarNovaReserva.TabIndex = 38;
            this.btnCriarNovaReserva.Text = "Criar nova reserva";
            this.btnCriarNovaReserva.UseVisualStyleBackColor = false;
            this.btnCriarNovaReserva.Click += new System.EventHandler(this.btnCriarNovaReserva_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(114, 119);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 33);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Reservas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalReserva
            // 
            this.lblTotalReserva.BackColor = System.Drawing.Color.White;
            this.lblTotalReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReserva.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalReserva.Location = new System.Drawing.Point(119, 285);
            this.lblTotalReserva.Name = "lblTotalReserva";
            this.lblTotalReserva.Size = new System.Drawing.Size(400, 33);
            this.lblTotalReserva.TabIndex = 46;
            this.lblTotalReserva.Text = "Total de reservas localizadas:";
            this.lblTotalReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.lblTotalReserva);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarNovaReserva);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstReservas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarNovaReserva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotalReserva;
        private System.Windows.Forms.TextBox txtPesquisaReserva;
        private System.Windows.Forms.Button btnFinalizadas;
        private System.Windows.Forms.Button btnCanceladas;
        private System.Windows.Forms.Button btnIniciadas;
        private System.Windows.Forms.Button btnConfirmadas;
    }
}