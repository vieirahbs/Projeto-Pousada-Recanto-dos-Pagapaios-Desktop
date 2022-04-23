
namespace RecantoDosPapagaios.TelasDeUsuarios
{
    partial class frmHospede
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("CPF");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Nome");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHospede));
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrarNovoHospede = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstHospede = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaHospede = new System.Windows.Forms.TextBox();
            this.btnBuscarHospedes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalHospedes = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(140, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hóspede";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrarNovoHospede
            // 
            this.btnCadastrarNovoHospede.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrarNovoHospede.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrarNovoHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovoHospede.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovoHospede.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarNovoHospede.Location = new System.Drawing.Point(751, 117);
            this.btnCadastrarNovoHospede.Name = "btnCadastrarNovoHospede";
            this.btnCadastrarNovoHospede.Size = new System.Drawing.Size(182, 37);
            this.btnCadastrarNovoHospede.TabIndex = 34;
            this.btnCadastrarNovoHospede.Text = "Cadastrar novo hóspede";
            this.btnCadastrarNovoHospede.UseVisualStyleBackColor = false;
            this.btnCadastrarNovoHospede.Click += new System.EventHandler(this.btnCadastrarNovoHospede_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lstHospede);
            this.panel2.Location = new System.Drawing.Point(134, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 273);
            this.panel2.TabIndex = 36;
            // 
            // lstHospede
            // 
            this.lstHospede.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstHospede.FullRowSelect = true;
            this.lstHospede.GridLines = true;
            this.lstHospede.HideSelection = false;
            this.lstHospede.HoverSelection = true;
            this.lstHospede.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstHospede.Location = new System.Drawing.Point(30, 23);
            this.lstHospede.Name = "lstHospede";
            this.lstHospede.Size = new System.Drawing.Size(750, 225);
            this.lstHospede.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstHospede.TabIndex = 0;
            this.lstHospede.UseCompatibleStateImageBehavior = false;
            this.lstHospede.View = System.Windows.Forms.View.Details;
            this.lstHospede.DoubleClick += new System.EventHandler(this.lstHospede_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.LegendaBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPesquisaHospede);
            this.panel1.Controls.Add(this.btnBuscarHospedes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(127, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 84);
            this.panel1.TabIndex = 35;
            // 
            // txtPesquisaHospede
            // 
            this.txtPesquisaHospede.Location = new System.Drawing.Point(177, 25);
            this.txtPesquisaHospede.Name = "txtPesquisaHospede";
            this.txtPesquisaHospede.Size = new System.Drawing.Size(522, 20);
            this.txtPesquisaHospede.TabIndex = 37;
            this.txtPesquisaHospede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaHospede_KeyPress);
            // 
            // btnBuscarHospedes
            // 
            this.btnBuscarHospedes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarHospedes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarHospedes.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarHospedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHospedes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHospedes.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHospedes.Location = new System.Drawing.Point(717, 19);
            this.btnBuscarHospedes.Name = "btnBuscarHospedes";
            this.btnBuscarHospedes.Size = new System.Drawing.Size(79, 30);
            this.btnBuscarHospedes.TabIndex = 36;
            this.btnBuscarHospedes.Text = "Buscar";
            this.btnBuscarHospedes.UseVisualStyleBackColor = false;
            this.btnBuscarHospedes.Click += new System.EventHandler(this.btnBuscarHospedes_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pesquisar CPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalHospedes
            // 
            this.lblTotalHospedes.BackColor = System.Drawing.Color.White;
            this.lblTotalHospedes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHospedes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalHospedes.Location = new System.Drawing.Point(148, 281);
            this.lblTotalHospedes.Name = "lblTotalHospedes";
            this.lblTotalHospedes.Size = new System.Drawing.Size(355, 33);
            this.lblTotalHospedes.TabIndex = 37;
            this.lblTotalHospedes.Text = "Total de hospedes localizados:";
            this.lblTotalHospedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 484);
            this.Controls.Add(this.lblTotalHospedes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarNovoHospede);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHospede";
            this.Text = "frmHospede";
            this.Load += new System.EventHandler(this.frmHospede_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrarNovoHospede;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarHospedes;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView lstHospede;
        private System.Windows.Forms.Label lblTotalHospedes;
        private System.Windows.Forms.TextBox txtPesquisaHospede;
        private System.Windows.Forms.Label label2;
    }
}