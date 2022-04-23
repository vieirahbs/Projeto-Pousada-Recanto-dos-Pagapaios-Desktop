
namespace RecantoDosPapagaios.TelasSecundarias
{
    partial class frmAtualizarChale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizarChale));
            this.lblTituloAtualizaCria = new System.Windows.Forms.Label();
            this.btnAtualizarCriarNovoChale = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbSelecionaChale = new System.Windows.Forms.ComboBox();
            this.openFileChaleFoto = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbFotoChale = new System.Windows.Forms.PictureBox();
            this.pcbEditarCriar = new System.Windows.Forms.PictureBox();
            this.txtNomeChale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.txtTipoCama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoChale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditarCriar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAtualizaCria
            // 
            this.lblTituloAtualizaCria.BackColor = System.Drawing.Color.White;
            this.lblTituloAtualizaCria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAtualizaCria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloAtualizaCria.Location = new System.Drawing.Point(104, 40);
            this.lblTituloAtualizaCria.Name = "lblTituloAtualizaCria";
            this.lblTituloAtualizaCria.Size = new System.Drawing.Size(154, 33);
            this.lblTituloAtualizaCria.TabIndex = 20;
            this.lblTituloAtualizaCria.Text = "Atualizar chalé";
            this.lblTituloAtualizaCria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtualizarCriarNovoChale
            // 
            this.btnAtualizarCriarNovoChale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizarCriarNovoChale.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAtualizarCriarNovoChale.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnAtualizarCriarNovoChale.FlatAppearance.BorderSize = 0;
            this.btnAtualizarCriarNovoChale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarCriarNovoChale.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarCriarNovoChale.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarCriarNovoChale.Location = new System.Drawing.Point(214, 434);
            this.btnAtualizarCriarNovoChale.Name = "btnAtualizarCriarNovoChale";
            this.btnAtualizarCriarNovoChale.Size = new System.Drawing.Size(561, 41);
            this.btnAtualizarCriarNovoChale.TabIndex = 8;
            this.btnAtualizarCriarNovoChale.Text = "Atualizar chalé";
            this.btnAtualizarCriarNovoChale.UseVisualStyleBackColor = false;
            this.btnAtualizarCriarNovoChale.Click += new System.EventHandler(this.btnAtualizarCriarNovoChale_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AllowDrop = true;
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.Gray;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 18;
            this.cmbCategoria.Location = new System.Drawing.Point(214, 194);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(179, 26);
            this.cmbCategoria.TabIndex = 2;
            // 
            // cmbSelecionaChale
            // 
            this.cmbSelecionaChale.AllowDrop = true;
            this.cmbSelecionaChale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelecionaChale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecionaChale.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbSelecionaChale.ForeColor = System.Drawing.Color.Gray;
            this.cmbSelecionaChale.FormattingEnabled = true;
            this.cmbSelecionaChale.ItemHeight = 18;
            this.cmbSelecionaChale.Location = new System.Drawing.Point(214, 143);
            this.cmbSelecionaChale.Name = "cmbSelecionaChale";
            this.cmbSelecionaChale.Size = new System.Drawing.Size(577, 26);
            this.cmbSelecionaChale.TabIndex = 1;
            this.cmbSelecionaChale.SelectedIndexChanged += new System.EventHandler(this.cmbSelecionaChale_SelectedIndexChanged);
            // 
            // openFileChaleFoto
            // 
            this.openFileChaleFoto.FileName = "Subir imagem do chalé";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(77, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Selecione o chalé:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(123, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categoria:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcbFotoChale
            // 
            this.pcbFotoChale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFotoChale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbFotoChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.imagemFundoUpLoad;
            this.pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFotoChale.InitialImage = global::RecantoDosPapagaios.Properties.Resources.imagemFundoUpLoad;
            this.pcbFotoChale.Location = new System.Drawing.Point(670, 343);
            this.pcbFotoChale.Name = "pcbFotoChale";
            this.pcbFotoChale.Size = new System.Drawing.Size(105, 70);
            this.pcbFotoChale.TabIndex = 41;
            this.pcbFotoChale.TabStop = false;
            // 
            // pcbEditarCriar
            // 
            this.pcbEditarCriar.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.EditarCinza;
            this.pcbEditarCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEditarCriar.Location = new System.Drawing.Point(62, 40);
            this.pcbEditarCriar.Name = "pcbEditarCriar";
            this.pcbEditarCriar.Size = new System.Drawing.Size(36, 32);
            this.pcbEditarCriar.TabIndex = 38;
            this.pcbEditarCriar.TabStop = false;
            // 
            // txtNomeChale
            // 
            this.txtNomeChale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeChale.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeChale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomeChale.Location = new System.Drawing.Point(586, 194);
            this.txtNomeChale.Name = "txtNomeChale";
            this.txtNomeChale.Size = new System.Drawing.Size(205, 26);
            this.txtNomeChale.TabIndex = 3;
            this.txtNomeChale.Tag = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(430, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nome do chalé:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTamanho.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTamanho.Location = new System.Drawing.Point(586, 241);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(205, 26);
            this.txtTamanho.TabIndex = 5;
            this.txtTamanho.Tag = "";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDiaria.Font = new System.Drawing.Font("Arial", 12F);
            this.txtValorDiaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorDiaria.Location = new System.Drawing.Point(586, 291);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(205, 26);
            this.txtValorDiaria.TabIndex = 7;
            this.txtValorDiaria.Tag = "";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacidade.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCapacidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCapacidade.Location = new System.Drawing.Point(214, 241);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(179, 26);
            this.txtCapacidade.TabIndex = 4;
            this.txtCapacidade.Tag = "";
            // 
            // txtTipoCama
            // 
            this.txtTipoCama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoCama.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTipoCama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoCama.Location = new System.Drawing.Point(214, 291);
            this.txtTipoCama.Name = "txtTipoCama";
            this.txtTipoCama.Size = new System.Drawing.Size(179, 26);
            this.txtTipoCama.TabIndex = 6;
            this.txtTipoCama.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(433, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tamanho (em metros)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(110, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Capacidade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(479, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Preço (diária):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(80, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tipo de cama:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAtualizarChale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.pcbFotoChale);
            this.Controls.Add(this.pcbEditarCriar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeChale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoCama);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.cmbSelecionaChale);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAtualizarCriarNovoChale);
            this.Controls.Add(this.lblTituloAtualizaCria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAtualizarChale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar chalé";
            this.Load += new System.EventHandler(this.frmAtualizarChale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoChale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditarCriar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAtualizaCria;
        private System.Windows.Forms.Button btnAtualizarCriarNovoChale;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbSelecionaChale;
        private System.Windows.Forms.OpenFileDialog openFileChaleFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbEditarCriar;
        private System.Windows.Forms.PictureBox pcbFotoChale;
        private System.Windows.Forms.TextBox txtNomeChale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.TextBox txtTipoCama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}