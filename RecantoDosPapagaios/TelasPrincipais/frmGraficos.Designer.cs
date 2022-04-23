
namespace RecantoDosPapagaios.TelasPrincipais
{
    partial class frmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficos));
            this.Chart02 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.Chart01 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart01)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart02
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart02.ChartAreas.Add(chartArea1);
            this.Chart02.Location = new System.Drawing.Point(83, 108);
            this.Chart02.Name = "Chart02";
            this.Chart02.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Chart02.Size = new System.Drawing.Size(300, 300);
            this.Chart02.TabIndex = 23;
            this.Chart02.Text = "Status Reserva";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(79, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gráficos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chart01
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart01.ChartAreas.Add(chartArea2);
            this.Chart01.Location = new System.Drawing.Point(455, 108);
            this.Chart01.Name = "Chart01";
            this.Chart01.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Chart01.Size = new System.Drawing.Size(300, 300);
            this.Chart01.TabIndex = 25;
            this.Chart01.Text = "Status Reserva";
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.Chart01);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Chart02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            this.Load += new System.EventHandler(this.frmGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart02;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart01;
    }
}