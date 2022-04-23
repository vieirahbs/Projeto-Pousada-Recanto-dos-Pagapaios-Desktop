
namespace RecantoDosPapagaios
{
    partial class frmTelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeLogin));
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEsqueceuSenha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNomeUsuarioEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnHideShowPasswordLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.AccessibleName = "";
            this.txtUsuarioEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuarioEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioEmail.Location = new System.Drawing.Point(262, 201);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(264, 21);
            this.txtUsuarioEmail.TabIndex = 0;
            this.txtUsuarioEmail.Tag = "";
            this.txtUsuarioEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioEmail_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Location = new System.Drawing.Point(262, 239);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 21);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Tag = "";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(285, 325);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(216, 37);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnEsqueceuSenha
            // 
            this.btnEsqueceuSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEsqueceuSenha.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsqueceuSenha.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnEsqueceuSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceuSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceuSenha.ForeColor = System.Drawing.Color.White;
            this.btnEsqueceuSenha.Location = new System.Drawing.Point(318, 274);
            this.btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            this.btnEsqueceuSenha.Size = new System.Drawing.Size(144, 28);
            this.btnEsqueceuSenha.TabIndex = 0;
            this.btnEsqueceuSenha.Text = "Esqueceu sua senha?";
            this.btnEsqueceuSenha.UseVisualStyleBackColor = false;
            this.btnEsqueceuSenha.Click += new System.EventHandler(this.btnEsqueceuSenha_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(715, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNomeUsuarioEmail
            // 
            this.lblNomeUsuarioEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeUsuarioEmail.AutoSize = true;
            this.lblNomeUsuarioEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuarioEmail.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuarioEmail.Location = new System.Drawing.Point(149, 204);
            this.lblNomeUsuarioEmail.Name = "lblNomeUsuarioEmail";
            this.lblNomeUsuarioEmail.Size = new System.Drawing.Size(106, 15);
            this.lblNomeUsuarioEmail.TabIndex = 4;
            this.lblNomeUsuarioEmail.Text = "Nome de usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(209, 242);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 15);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // btnHideShowPasswordLog
            // 
            this.btnHideShowPasswordLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHideShowPasswordLog.BackColor = System.Drawing.Color.Transparent;
            this.btnHideShowPasswordLog.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.EyeHidenWhite;
            this.btnHideShowPasswordLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideShowPasswordLog.FlatAppearance.BorderSize = 0;
            this.btnHideShowPasswordLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowPasswordLog.Location = new System.Drawing.Point(529, 240);
            this.btnHideShowPasswordLog.Name = "btnHideShowPasswordLog";
            this.btnHideShowPasswordLog.Size = new System.Drawing.Size(25, 21);
            this.btnHideShowPasswordLog.TabIndex = 18;
            this.btnHideShowPasswordLog.UseVisualStyleBackColor = false;
            this.btnHideShowPasswordLog.Click += new System.EventHandler(this.btnHideShowPasswordLog_Click);
            // 
            // frmTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHideShowPasswordLog);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeUsuarioEmail);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEsqueceuSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuarioEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recanto dos papagaios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEsqueceuSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNomeUsuarioEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnHideShowPasswordLog;
    }
}

