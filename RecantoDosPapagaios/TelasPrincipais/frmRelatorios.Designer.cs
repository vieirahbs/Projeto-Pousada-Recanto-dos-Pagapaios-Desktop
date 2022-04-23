
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.lblTituloRelatorio = new System.Windows.Forms.Label();
            this.sfdExportarRelatorio = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cmbSelecionaTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloRelatorio
            // 
            this.lblTituloRelatorio.BackColor = System.Drawing.Color.White;
            this.lblTituloRelatorio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRelatorio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloRelatorio.Location = new System.Drawing.Point(111, 51);
            this.lblTituloRelatorio.Name = "lblTituloRelatorio";
            this.lblTituloRelatorio.Size = new System.Drawing.Size(184, 33);
            this.lblTituloRelatorio.TabIndex = 21;
            this.lblTituloRelatorio.Text = "Relatórios";
            this.lblTituloRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(94, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 130);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnGerarRelatorio);
            this.panel2.Controls.Add(this.dtpDataFinal);
            this.panel2.Controls.Add(this.dtpDataInicial);
            this.panel2.Controls.Add(this.cmbSelecionaTipoRelatorio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(30, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 79);
            this.panel2.TabIndex = 0;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGerarRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(634, 15);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(148, 26);
            this.btnGerarRelatorio.TabIndex = 61;
            this.btnGerarRelatorio.Text = "Exportar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click_1);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataFinal.Location = new System.Drawing.Point(398, 46);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(210, 20);
            this.dtpDataFinal.TabIndex = 59;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDataInicial.Location = new System.Drawing.Point(162, 46);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(208, 20);
            this.dtpDataInicial.TabIndex = 58;
            // 
            // cmbSelecionaTipoRelatorio
            // 
            this.cmbSelecionaTipoRelatorio.AllowDrop = true;
            this.cmbSelecionaTipoRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelecionaTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecionaTipoRelatorio.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbSelecionaTipoRelatorio.ForeColor = System.Drawing.Color.Gray;
            this.cmbSelecionaTipoRelatorio.FormattingEnabled = true;
            this.cmbSelecionaTipoRelatorio.Location = new System.Drawing.Point(162, 12);
            this.cmbSelecionaTipoRelatorio.Name = "cmbSelecionaTipoRelatorio";
            this.cmbSelecionaTipoRelatorio.Size = new System.Drawing.Size(446, 26);
            this.cmbSelecionaTipoRelatorio.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(80, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Período";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tipo de relatório";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTituloRelatorio;
        private System.Windows.Forms.SaveFileDialog sfdExportarRelatorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        public System.Windows.Forms.ComboBox cmbSelecionaTipoRelatorio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}