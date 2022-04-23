
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstCheckOut = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCheckOut = new System.Windows.Forms.Button();
            this.btnCriarNovaReserva = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCheckOut = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.FundoChales;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lstCheckOut);
            this.panel2.Location = new System.Drawing.Point(114, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 273);
            this.panel2.TabIndex = 48;
            // 
            // lstCheckOut
            // 
            this.lstCheckOut.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstCheckOut.FullRowSelect = true;
            this.lstCheckOut.GridLines = true;
            this.lstCheckOut.HideSelection = false;
            this.lstCheckOut.HotTracking = true;
            this.lstCheckOut.HoverSelection = true;
            this.lstCheckOut.Location = new System.Drawing.Point(30, 23);
            this.lstCheckOut.Name = "lstCheckOut";
            this.lstCheckOut.Size = new System.Drawing.Size(750, 225);
            this.lstCheckOut.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstCheckOut.TabIndex = 0;
            this.lstCheckOut.UseCompatibleStateImageBehavior = false;
            this.lstCheckOut.View = System.Windows.Forms.View.Details;
            this.lstCheckOut.DoubleClick += new System.EventHandler(this.lstCheckOut_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.LegendaBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtPesquisaReserva);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscarCheckOut);
            this.panel1.Location = new System.Drawing.Point(107, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 84);
            this.panel1.TabIndex = 47;
            // 
            // txtPesquisaReserva
            // 
            this.txtPesquisaReserva.Location = new System.Drawing.Point(169, 25);
            this.txtPesquisaReserva.Name = "txtPesquisaReserva";
            this.txtPesquisaReserva.Size = new System.Drawing.Size(526, 20);
            this.txtPesquisaReserva.TabIndex = 41;
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
            this.label2.TabIndex = 40;
            this.label2.Text = "Filtrar por CPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarCheckOut
            // 
            this.btnBuscarCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCheckOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscarCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCheckOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCheckOut.Location = new System.Drawing.Point(708, 19);
            this.btnBuscarCheckOut.Name = "btnBuscarCheckOut";
            this.btnBuscarCheckOut.Size = new System.Drawing.Size(79, 30);
            this.btnBuscarCheckOut.TabIndex = 36;
            this.btnBuscarCheckOut.Text = "Buscar";
            this.btnBuscarCheckOut.UseVisualStyleBackColor = false;
            this.btnBuscarCheckOut.Click += new System.EventHandler(this.btnBuscarCheckOut_Click);
            // 
            // btnCriarNovaReserva
            // 
            this.btnCriarNovaReserva.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCriarNovaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarNovaReserva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovaReserva.ForeColor = System.Drawing.Color.White;
            this.btnCriarNovaReserva.Location = new System.Drawing.Point(731, 119);
            this.btnCriarNovaReserva.Name = "btnCriarNovaReserva";
            this.btnCriarNovaReserva.Size = new System.Drawing.Size(182, 37);
            this.btnCriarNovaReserva.TabIndex = 46;
            this.btnCriarNovaReserva.Text = "Criar nova reserva";
            this.btnCriarNovaReserva.UseVisualStyleBackColor = false;
            this.btnCriarNovaReserva.Click += new System.EventHandler(this.btnCriarNovaReserva_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(120, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 33);
            this.label9.TabIndex = 45;
            this.label9.Text = "Check-out";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCheckOut
            // 
            this.lblTotalCheckOut.BackColor = System.Drawing.Color.White;
            this.lblTotalCheckOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCheckOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCheckOut.Location = new System.Drawing.Point(126, 287);
            this.lblTotalCheckOut.Name = "lblTotalCheckOut";
            this.lblTotalCheckOut.Size = new System.Drawing.Size(522, 33);
            this.lblTotalCheckOut.TabIndex = 49;
            this.lblTotalCheckOut.Text = "Total de check-outs localizados:";
            this.lblTotalCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCheckOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarNovaReserva);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckOut";
            this.Text = "frmCheckOut";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstCheckOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarCheckOut;
        private System.Windows.Forms.Button btnCriarNovaReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCheckOut;
        private System.Windows.Forms.TextBox txtPesquisaReserva;
        private System.Windows.Forms.Label label2;
    }
}