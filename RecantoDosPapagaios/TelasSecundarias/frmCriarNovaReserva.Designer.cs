
namespace RecantoDosPapagaios.TelasSecundarias
{
    partial class frmCriarNovaReserva
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarNovaReserva));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCriancaQtd = new System.Windows.Forms.Label();
            this.btnCriancaMenos = new System.Windows.Forms.Button();
            this.btnCriancaMais = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdultoQtd = new System.Windows.Forms.Label();
            this.btnAdultoMenos = new System.Windows.Forms.Button();
            this.btnAdultoMais = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarReserva = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarCPF = new System.Windows.Forms.Button();
            this.txtCPFBusca = new System.Windows.Forms.TextBox();
            this.cmbSelecionarChale = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(this.label5);
            panel1.Controls.Add(this.cmbPagamento);
            panel1.Controls.Add(this.panel2);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.dtpCheckOut);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.dtpCheckIn);
            panel1.Controls.Add(this.btnSalvarReserva);
            panel1.Controls.Add(this.label12);
            panel1.Controls.Add(this.btnBuscarCPF);
            panel1.Controls.Add(this.txtCPFBusca);
            panel1.Controls.Add(this.cmbSelecionarChale);
            panel1.Controls.Add(this.label2);
            panel1.Location = new System.Drawing.Point(34, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(820, 365);
            panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(463, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Pagamento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagamento.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbPagamento.ForeColor = System.Drawing.Color.Gray;
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.ItemHeight = 18;
            this.cmbPagamento.Location = new System.Drawing.Point(559, 88);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(214, 26);
            this.cmbPagamento.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblCriancaQtd);
            this.panel2.Controls.Add(this.btnCriancaMenos);
            this.panel2.Controls.Add(this.btnCriancaMais);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblAdultoQtd);
            this.panel2.Controls.Add(this.btnAdultoMenos);
            this.panel2.Controls.Add(this.btnAdultoMais);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(220, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 83);
            this.panel2.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(191, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "até 6 anos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCriancaQtd
            // 
            this.lblCriancaQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCriancaQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblCriancaQtd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCriancaQtd.ForeColor = System.Drawing.Color.DimGray;
            this.lblCriancaQtd.Location = new System.Drawing.Point(285, 29);
            this.lblCriancaQtd.Name = "lblCriancaQtd";
            this.lblCriancaQtd.Size = new System.Drawing.Size(22, 20);
            this.lblCriancaQtd.TabIndex = 50;
            this.lblCriancaQtd.Text = "0";
            this.lblCriancaQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCriancaMenos
            // 
            this.btnCriancaMenos.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Subtracao;
            this.btnCriancaMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriancaMenos.FlatAppearance.BorderSize = 0;
            this.btnCriancaMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriancaMenos.Location = new System.Drawing.Point(312, 26);
            this.btnCriancaMenos.Name = "btnCriancaMenos";
            this.btnCriancaMenos.Size = new System.Drawing.Size(25, 25);
            this.btnCriancaMenos.TabIndex = 10;
            this.btnCriancaMenos.UseVisualStyleBackColor = true;
            this.btnCriancaMenos.Click += new System.EventHandler(this.btnCriancaMenos_Click);
            // 
            // btnCriancaMais
            // 
            this.btnCriancaMais.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Adicao;
            this.btnCriancaMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriancaMais.FlatAppearance.BorderSize = 0;
            this.btnCriancaMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriancaMais.Location = new System.Drawing.Point(254, 25);
            this.btnCriancaMais.Name = "btnCriancaMais";
            this.btnCriancaMais.Size = new System.Drawing.Size(28, 28);
            this.btnCriancaMais.TabIndex = 9;
            this.btnCriancaMais.UseVisualStyleBackColor = true;
            this.btnCriancaMais.Click += new System.EventHandler(this.btnCriancaMais_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(185, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Crianças";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdultoQtd
            // 
            this.lblAdultoQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdultoQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdultoQtd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAdultoQtd.ForeColor = System.Drawing.Color.DimGray;
            this.lblAdultoQtd.Location = new System.Drawing.Point(104, 29);
            this.lblAdultoQtd.Name = "lblAdultoQtd";
            this.lblAdultoQtd.Size = new System.Drawing.Size(22, 20);
            this.lblAdultoQtd.TabIndex = 46;
            this.lblAdultoQtd.Text = "0";
            this.lblAdultoQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdultoMenos
            // 
            this.btnAdultoMenos.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Subtracao;
            this.btnAdultoMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdultoMenos.FlatAppearance.BorderSize = 0;
            this.btnAdultoMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdultoMenos.Location = new System.Drawing.Point(130, 26);
            this.btnAdultoMenos.Name = "btnAdultoMenos";
            this.btnAdultoMenos.Size = new System.Drawing.Size(25, 25);
            this.btnAdultoMenos.TabIndex = 8;
            this.btnAdultoMenos.UseVisualStyleBackColor = true;
            this.btnAdultoMenos.Click += new System.EventHandler(this.btnAdultoMenos_Click);
            // 
            // btnAdultoMais
            // 
            this.btnAdultoMais.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Adicao;
            this.btnAdultoMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdultoMais.FlatAppearance.BorderSize = 0;
            this.btnAdultoMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdultoMais.Location = new System.Drawing.Point(73, 25);
            this.btnAdultoMais.Name = "btnAdultoMais";
            this.btnAdultoMais.Size = new System.Drawing.Size(28, 28);
            this.btnAdultoMais.TabIndex = 7;
            this.btnAdultoMais.UseVisualStyleBackColor = true;
            this.btnAdultoMais.Click += new System.EventHandler(this.btnAdultoMais_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Adultos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(440, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data de check-in";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(563, 133);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(210, 20);
            this.dtpCheckOut.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(93, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Data de check-in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(219, 133);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(215, 20);
            this.dtpCheckIn.TabIndex = 5;
            // 
            // btnSalvarReserva
            // 
            this.btnSalvarReserva.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvarReserva.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalvarReserva.FlatAppearance.BorderSize = 0;
            this.btnSalvarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarReserva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarReserva.ForeColor = System.Drawing.Color.White;
            this.btnSalvarReserva.Location = new System.Drawing.Point(219, 278);
            this.btnSalvarReserva.Name = "btnSalvarReserva";
            this.btnSalvarReserva.Size = new System.Drawing.Size(362, 24);
            this.btnSalvarReserva.TabIndex = 11;
            this.btnSalvarReserva.Text = "Salvar reserva";
            this.btnSalvarReserva.UseVisualStyleBackColor = false;
            this.btnSalvarReserva.Click += new System.EventHandler(this.btnSalvarReserva_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(86, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Selecionar Chalé:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarCPF
            // 
            this.btnBuscarCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCPF.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCPF.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCPF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCPF.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCPF.Location = new System.Drawing.Point(609, 24);
            this.btnBuscarCPF.Name = "btnBuscarCPF";
            this.btnBuscarCPF.Size = new System.Drawing.Size(76, 24);
            this.btnBuscarCPF.TabIndex = 2;
            this.btnBuscarCPF.Text = "Buscar";
            this.btnBuscarCPF.UseVisualStyleBackColor = false;
            this.btnBuscarCPF.Click += new System.EventHandler(this.btnBuscarCPF_Click);
            // 
            // txtCPFBusca
            // 
            this.txtCPFBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPFBusca.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCPFBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPFBusca.Location = new System.Drawing.Point(219, 23);
            this.txtCPFBusca.Name = "txtCPFBusca";
            this.txtCPFBusca.Size = new System.Drawing.Size(363, 26);
            this.txtCPFBusca.TabIndex = 1;
            this.txtCPFBusca.Tag = "";
            this.txtCPFBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFBusca_KeyPress);
            // 
            // cmbSelecionarChale
            // 
            this.cmbSelecionarChale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelecionarChale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecionarChale.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbSelecionarChale.ForeColor = System.Drawing.Color.Gray;
            this.cmbSelecionarChale.FormattingEnabled = true;
            this.cmbSelecionarChale.ItemHeight = 18;
            this.cmbSelecionarChale.Location = new System.Drawing.Point(220, 88);
            this.cmbSelecionarChale.Name = "cmbSelecionarChale";
            this.cmbSelecionarChale.Size = new System.Drawing.Size(214, 26);
            this.cmbSelecionarChale.TabIndex = 20;
            this.cmbSelecionarChale.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionarChale_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Digite o CPF do hóspede";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(37, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 33);
            this.label9.TabIndex = 35;
            this.label9.Text = "Criar nova reserva";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCriarNovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 461);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCriarNovaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar nova reserva";
            this.Load += new System.EventHandler(this.frmCriarNovaReserva_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarReserva;
        private System.Windows.Forms.Button btnBuscarCPF;
        private System.Windows.Forms.TextBox txtCPFBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdultoMais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdultoMenos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCriancaQtd;
        private System.Windows.Forms.Button btnCriancaMenos;
        private System.Windows.Forms.Button btnCriancaMais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdultoQtd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSelecionarChale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPagamento;
    }
}