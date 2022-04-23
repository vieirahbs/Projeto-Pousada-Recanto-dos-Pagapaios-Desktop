
namespace RecantoDosPapagaios.TelasSecundarias
{
    partial class frmReservaDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaDetalhe));
            this.lblCodigoReserva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusReserva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFazerCheckOut = new System.Windows.Forms.Button();
            this.btnFazerCheckIn = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReservaDetalhes = new System.Windows.Forms.TextBox();
            this.pcbChale = new System.Windows.Forms.PictureBox();
            this.btnCancelarReservar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoReserva
            // 
            this.lblCodigoReserva.BackColor = System.Drawing.Color.White;
            this.lblCodigoReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoReserva.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCodigoReserva.Location = new System.Drawing.Point(198, 40);
            this.lblCodigoReserva.Name = "lblCodigoReserva";
            this.lblCodigoReserva.Size = new System.Drawing.Size(225, 33);
            this.lblCodigoReserva.TabIndex = 16;
            this.lblCodigoReserva.Text = "Reserva";
            this.lblCodigoReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(88, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reserva   #";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblStatusReserva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFazerCheckOut);
            this.panel1.Controls.Add(this.btnFazerCheckIn);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblValorDiaria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtReservaDetalhes);
            this.panel1.Controls.Add(this.pcbChale);
            this.panel1.Location = new System.Drawing.Point(80, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 351);
            this.panel1.TabIndex = 17;
            // 
            // lblStatusReserva
            // 
            this.lblStatusReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusReserva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusReserva.ForeColor = System.Drawing.Color.Chocolate;
            this.lblStatusReserva.Location = new System.Drawing.Point(425, 30);
            this.lblStatusReserva.Name = "lblStatusReserva";
            this.lblStatusReserva.Size = new System.Drawing.Size(143, 20);
            this.lblStatusReserva.TabIndex = 39;
            this.lblStatusReserva.Text = "Status";
            this.lblStatusReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(315, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status da reserva:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFazerCheckOut
            // 
            this.btnFazerCheckOut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFazerCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnFazerCheckOut.FlatAppearance.BorderSize = 0;
            this.btnFazerCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerCheckOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnFazerCheckOut.Location = new System.Drawing.Point(463, 278);
            this.btnFazerCheckOut.Name = "btnFazerCheckOut";
            this.btnFazerCheckOut.Size = new System.Drawing.Size(149, 32);
            this.btnFazerCheckOut.TabIndex = 38;
            this.btnFazerCheckOut.Text = "Fazer check-Out";
            this.btnFazerCheckOut.UseVisualStyleBackColor = false;
            this.btnFazerCheckOut.Click += new System.EventHandler(this.btnFazerCheckOut_Click);
            // 
            // btnFazerCheckIn
            // 
            this.btnFazerCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFazerCheckIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFazerCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnFazerCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerCheckIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnFazerCheckIn.Location = new System.Drawing.Point(463, 237);
            this.btnFazerCheckIn.Name = "btnFazerCheckIn";
            this.btnFazerCheckIn.Size = new System.Drawing.Size(149, 33);
            this.btnFazerCheckIn.TabIndex = 34;
            this.btnFazerCheckIn.Text = "Fazer check-in";
            this.btnFazerCheckIn.UseVisualStyleBackColor = false;
            this.btnFazerCheckIn.Click += new System.EventHandler(this.btnFazerCheckIn_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblValorTotal.Location = new System.Drawing.Point(270, 235);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(175, 33);
            this.lblValorTotal.TabIndex = 21;
            this.lblValorTotal.Text = "R$ 00,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(271, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "/total a pagar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(118, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "/diária";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDiaria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiaria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblValorDiaria.Location = new System.Drawing.Point(117, 236);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(130, 33);
            this.lblValorDiaria.TabIndex = 18;
            this.lblValorDiaria.Text = "R$ 00,00";
            this.lblValorDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(61, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Preço:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReservaDetalhes
            // 
            this.txtReservaDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReservaDetalhes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReservaDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservaDetalhes.Enabled = false;
            this.txtReservaDetalhes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservaDetalhes.ForeColor = System.Drawing.Color.DimGray;
            this.txtReservaDetalhes.Location = new System.Drawing.Point(316, 57);
            this.txtReservaDetalhes.Multiline = true;
            this.txtReservaDetalhes.Name = "txtReservaDetalhes";
            this.txtReservaDetalhes.Size = new System.Drawing.Size(296, 144);
            this.txtReservaDetalhes.TabIndex = 11;
            this.txtReservaDetalhes.Text = "Informações da reserva:";
            // 
            // pcbChale
            // 
            this.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
            this.pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbChale.Location = new System.Drawing.Point(32, 27);
            this.pcbChale.Name = "pcbChale";
            this.pcbChale.Size = new System.Drawing.Size(261, 174);
            this.pcbChale.TabIndex = 0;
            this.pcbChale.TabStop = false;
            // 
            // btnCancelarReservar
            // 
            this.btnCancelarReservar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarReservar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelarReservar.FlatAppearance.BorderSize = 0;
            this.btnCancelarReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReservar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReservar.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReservar.Location = new System.Drawing.Point(581, 52);
            this.btnCancelarReservar.Name = "btnCancelarReservar";
            this.btnCancelarReservar.Size = new System.Drawing.Size(127, 32);
            this.btnCancelarReservar.TabIndex = 40;
            this.btnCancelarReservar.Text = "Cancelar reserva";
            this.btnCancelarReservar.UseVisualStyleBackColor = false;
            this.btnCancelarReservar.Click += new System.EventHandler(this.btnCancelarReservar_Click);
            // 
            // frmReservaDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btnCancelarReservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodigoReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReservaDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhe de reserva";
            this.Load += new System.EventHandler(this.frmReservaDetalhe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pcbChale;
        public System.Windows.Forms.Label lblCodigoReserva;
        public System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblValorDiaria;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtReservaDetalhes;
        public System.Windows.Forms.Button btnFazerCheckIn;
        public System.Windows.Forms.Button btnFazerCheckOut;
        public System.Windows.Forms.Label lblStatusReserva;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnCancelarReservar;
    }
}