
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmFuncionarios
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
            this.lblTotalFuncionarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstFuncionario = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarNovoFuncionario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalFuncionarios
            // 
            this.lblTotalFuncionarios.BackColor = System.Drawing.Color.White;
            this.lblTotalFuncionarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFuncionarios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalFuncionarios.Location = new System.Drawing.Point(82, 281);
            this.lblTotalFuncionarios.Name = "lblTotalFuncionarios";
            this.lblTotalFuncionarios.Size = new System.Drawing.Size(355, 33);
            this.lblTotalFuncionarios.TabIndex = 42;
            this.lblTotalFuncionarios.Text = "Total de funcionários localizados:";
            this.lblTotalFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lstFuncionario);
            this.panel2.Location = new System.Drawing.Point(68, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 273);
            this.panel2.TabIndex = 41;
            // 
            // lstFuncionario
            // 
            this.lstFuncionario.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstFuncionario.FullRowSelect = true;
            this.lstFuncionario.GridLines = true;
            this.lstFuncionario.HideSelection = false;
            this.lstFuncionario.HoverSelection = true;
            this.lstFuncionario.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstFuncionario.Location = new System.Drawing.Point(30, 23);
            this.lstFuncionario.Name = "lstFuncionario";
            this.lstFuncionario.Size = new System.Drawing.Size(750, 225);
            this.lstFuncionario.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstFuncionario.TabIndex = 0;
            this.lstFuncionario.UseCompatibleStateImageBehavior = false;
            this.lstFuncionario.View = System.Windows.Forms.View.Details;
            this.lstFuncionario.DoubleClick += new System.EventHandler(this.lstFuncionario_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.LegendaBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPesquisaFuncionario);
            this.panel1.Controls.Add(this.btnBuscarFuncionario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(61, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 84);
            this.panel1.TabIndex = 40;
            // 
            // txtPesquisaFuncionario
            // 
            this.txtPesquisaFuncionario.Location = new System.Drawing.Point(180, 25);
            this.txtPesquisaFuncionario.Name = "txtPesquisaFuncionario";
            this.txtPesquisaFuncionario.Size = new System.Drawing.Size(519, 20);
            this.txtPesquisaFuncionario.TabIndex = 37;
            this.txtPesquisaFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaFuncionario_KeyPress);
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFuncionario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(717, 19);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(79, 30);
            this.btnBuscarFuncionario.TabIndex = 36;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
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
            // btnCadastrarNovoFuncionario
            // 
            this.btnCadastrarNovoFuncionario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrarNovoFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrarNovoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovoFuncionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovoFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarNovoFuncionario.Location = new System.Drawing.Point(665, 117);
            this.btnCadastrarNovoFuncionario.Name = "btnCadastrarNovoFuncionario";
            this.btnCadastrarNovoFuncionario.Size = new System.Drawing.Size(202, 37);
            this.btnCadastrarNovoFuncionario.TabIndex = 39;
            this.btnCadastrarNovoFuncionario.Text = "Cadastrar novo funcionário";
            this.btnCadastrarNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarNovoFuncionario.Click += new System.EventHandler(this.btnCadastrarNovoFuncionario_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(74, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 33);
            this.label9.TabIndex = 38;
            this.label9.Text = "Funcionários";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 501);
            this.Controls.Add(this.lblTotalFuncionarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarNovoFuncionario);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalFuncionarios;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView lstFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisaFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarNovoFuncionario;
        private System.Windows.Forms.Label label9;
    }
}