namespace MensajesAuto
{
    partial class Form2
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
            this.txtMesajeAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lvMensajesCargados = new System.Windows.Forms.ListView();
            this.btnGuardarMensajeArchivo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesajeAgregar
            // 
            this.txtMesajeAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesajeAgregar.ForeColor = System.Drawing.Color.Lime;
            this.txtMesajeAgregar.Location = new System.Drawing.Point(14, 32);
            this.txtMesajeAgregar.Multiline = true;
            this.txtMesajeAgregar.Name = "txtMesajeAgregar";
            this.txtMesajeAgregar.Size = new System.Drawing.Size(621, 99);
            this.txtMesajeAgregar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(274, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensaje";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Lime;
            this.btnCargar.Location = new System.Drawing.Point(242, 137);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(161, 59);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lvMensajesCargados
            // 
            this.lvMensajesCargados.CheckBoxes = true;
            this.lvMensajesCargados.HideSelection = false;
            this.lvMensajesCargados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvMensajesCargados.Location = new System.Drawing.Point(12, 202);
            this.lvMensajesCargados.Name = "lvMensajesCargados";
            this.lvMensajesCargados.Size = new System.Drawing.Size(623, 245);
            this.lvMensajesCargados.TabIndex = 3;
            this.lvMensajesCargados.UseCompatibleStateImageBehavior = false;
            this.lvMensajesCargados.View = System.Windows.Forms.View.List;
            // 
            // btnGuardarMensajeArchivo
            // 
            this.btnGuardarMensajeArchivo.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnGuardarMensajeArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMensajeArchivo.ForeColor = System.Drawing.Color.Lime;
            this.btnGuardarMensajeArchivo.Location = new System.Drawing.Point(474, 453);
            this.btnGuardarMensajeArchivo.Name = "btnGuardarMensajeArchivo";
            this.btnGuardarMensajeArchivo.Size = new System.Drawing.Size(161, 59);
            this.btnGuardarMensajeArchivo.TabIndex = 4;
            this.btnGuardarMensajeArchivo.Text = "Guardar";
            this.btnGuardarMensajeArchivo.UseVisualStyleBackColor = false;
            this.btnGuardarMensajeArchivo.Click += new System.EventHandler(this.Guardar_a_archivo);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Lime;
            this.btnEliminar.Location = new System.Drawing.Point(14, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 59);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(647, 585);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardarMensajeArchivo);
            this.Controls.Add(this.lvMensajesCargados);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesajeAgregar);
            this.Name = "Form2";
            this.Text = "CargarMensajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesajeAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListView lvMensajesCargados;
        private System.Windows.Forms.Button btnGuardarMensajeArchivo;
        private System.Windows.Forms.Button btnEliminar;
    }
}