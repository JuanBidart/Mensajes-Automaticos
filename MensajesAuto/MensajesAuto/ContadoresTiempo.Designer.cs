namespace MensajesAuto
{
    partial class ContadoresTiempo
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
            this.lblhorares = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.lblminres = new System.Windows.Forms.Label();
            this.lblsegres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhorares
            // 
            this.lblhorares.AutoSize = true;
            this.lblhorares.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorares.ForeColor = System.Drawing.Color.Lime;
            this.lblhorares.Location = new System.Drawing.Point(41, 80);
            this.lblhorares.Name = "lblhorares";
            this.lblhorares.Size = new System.Drawing.Size(41, 29);
            this.lblhorares.TabIndex = 0;
            this.lblhorares.Text = "00";
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.ForeColor = System.Drawing.Color.Lime;
            this.lblTiempoRestante.Location = new System.Drawing.Point(42, 42);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(146, 20);
            this.lblTiempoRestante.TabIndex = 1;
            this.lblTiempoRestante.Text = "Tiempo Restante";
            // 
            // lblminres
            // 
            this.lblminres.AutoSize = true;
            this.lblminres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminres.ForeColor = System.Drawing.Color.Lime;
            this.lblminres.Location = new System.Drawing.Point(94, 80);
            this.lblminres.Name = "lblminres";
            this.lblminres.Size = new System.Drawing.Size(41, 29);
            this.lblminres.TabIndex = 2;
            this.lblminres.Text = "00";
            // 
            // lblsegres
            // 
            this.lblsegres.AutoSize = true;
            this.lblsegres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsegres.ForeColor = System.Drawing.Color.Lime;
            this.lblsegres.Location = new System.Drawing.Point(147, 80);
            this.lblsegres.Name = "lblsegres";
            this.lblsegres.Size = new System.Drawing.Size(41, 29);
            this.lblsegres.TabIndex = 3;
            this.lblsegres.Text = "00";
            // 
            // ContadoresTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(549, 187);
            this.Controls.Add(this.lblsegres);
            this.Controls.Add(this.lblminres);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblhorares);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContadoresTiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContadoresTiempo";
            this.Load += new System.EventHandler(this.ContadoresTiempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhorares;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label lblminres;
        public System.Windows.Forms.Label lblsegres;
    }
}