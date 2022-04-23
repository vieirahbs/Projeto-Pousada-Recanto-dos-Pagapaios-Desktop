
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstCheckIn = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCheckIn = new System.Windows.Forms.Button();
            this.btnCriarNovaReserva = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCheckIn = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lstCheckIn);
            this.panel2.Location = new System.Drawing.Point(114, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 273);
            this.panel2.TabIndex = 44;
            // 
            // lstCheckIn
            // 
            this.lstCheckIn.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstCheckIn.FullRowSelect = true;
            this.lstCheckIn.GridLines = true;
            this.lstCheckIn.HideSelection = false;
            this.lstCheckIn.HoverSelection = true;
            this.lstCheckIn.Location = new System.Drawing.Point(30, 23);
            this.lstCheckIn.Name = "lstCheckIn";
            this.lstCheckIn.Size = new System.Drawing.Size(750, 225);
            this.lstCheckIn.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstCheckIn.TabIndex = 0;
            this.lstCheckIn.UseCompatibleStateImageBehavior = false;
            this.lstCheckIn.View = System.Windows.Forms.View.Details;
            this.lstCheckIn.DoubleClick += new System.EventHandler(this.lstCheckIn_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.LegendaBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPesquisaReserva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscarCheckIn);
            this.panel1.Location = new System.Drawing.Point(107, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 84);
            this.panel1.TabIndex = 43;
            // 
            // txtPesquisaReserva
            // 
            this.txtPesquisaReserva.Location = new System.Drawing.Point(169, 25);
            this.txtPesquisaReserva.Name = "txtPesquisaReserva";
            this.txtPesquisaReserva.Size = new System.Drawing.Size(526, 20);
            this.txtPesquisaReserva.TabIndex = 39;
            this.txtPesquisaReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaReserva_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Filtrar por CPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarCheckIn
            // 
            this.btnBuscarCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCheckIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCheckIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCheckIn.Location = new System.Drawing.Point(708, 19);
            this.btnBuscarCheckIn.Name = "btnBuscarCheckIn";
            this.btnBuscarCheckIn.Size = new System.Drawing.Size(79, 30);
            this.btnBuscarCheckIn.TabIndex = 36;
            this.btnBuscarCheckIn.Text = "Buscar";
            this.btnBuscarCheckIn.UseVisualStyleBackColor = false;
            this.btnBuscarCheckIn.Click += new System.EventHandler(this.btnBuscarCheckIn_Click);
            // 
            // btnCriarNovaReserva
            // 
            this.btnCriarNovaReserva.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarNovaReserva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovaReserva.ForeColor = System.Drawing.Color.White;
            this.btnCriarNovaReserva.Location = new System.Drawing.Point(731, 121);
            this.btnCriarNovaReserva.Name = "btnCriarNovaReserva";
            this.btnCriarNovaReserva.Size = new System.Drawing.Size(182, 37);
            this.btnCriarNovaReserva.TabIndex = 42;
            this.btnCriarNovaReserva.Text = "Criar nova reserva";
            this.btnCriarNovaReserva.UseVisualStyleBackColor = false;
            this.btnCriarNovaReserva.Click += new System.EventHandler(this.btnCriarNovaReserva_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(120, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 41;
            this.label9.Text = "Check-In";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCheckIn
            // 
            this.lblTotalCheckIn.BackColor = System.Drawing.Color.White;
            this.lblTotalCheckIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCheckIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCheckIn.Location = new System.Drawing.Point(128, 286);
            this.lblTotalCheckIn.Name = "lblTotalCheckIn";
            this.lblTotalCheckIn.Size = new System.Drawing.Size(525, 33);
            this.lblTotalCheckIn.TabIndex = 45;
            this.lblTotalCheckIn.Text = "Total de check-ins localizados:";
            this.lblTotalCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCheckIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarNovaReserva);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckIn";
            this.Text = "frmCheckIn";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstCheckIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarCheckIn;
        private System.Windows.Forms.Button btnCriarNovaReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCheckIn;
        private System.Windows.Forms.TextBox txtPesquisaReserva;
        private System.Windows.Forms.Label label2;
    }
}