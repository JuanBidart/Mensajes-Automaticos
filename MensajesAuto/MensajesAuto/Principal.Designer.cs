﻿namespace MensajesAuto
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTiempodeEspera = new System.Windows.Forms.TextBox();
            this.lblTiempodeEspera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.cbxAleatorio = new System.Windows.Forms.CheckBox();
            this.cbxIncluirFecha = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvMensajes = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantMens = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura XBlkCnIt BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(168, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 70);
            this.panel1.TabIndex = 1;
            // 
            // txtTiempodeEspera
            // 
            this.txtTiempodeEspera.AccessibleDescription = "En segundos";
            this.txtTiempodeEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempodeEspera.Location = new System.Drawing.Point(19, 107);
            this.txtTiempodeEspera.Name = "txtTiempodeEspera";
            this.txtTiempodeEspera.Size = new System.Drawing.Size(131, 29);
            this.txtTiempodeEspera.TabIndex = 0;
            // 
            // lblTiempodeEspera
            // 
            this.lblTiempodeEspera.AutoSize = true;
            this.lblTiempodeEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempodeEspera.ForeColor = System.Drawing.Color.Lime;
            this.lblTiempodeEspera.Location = new System.Drawing.Point(12, 85);
            this.lblTiempodeEspera.Name = "lblTiempodeEspera";
            this.lblTiempodeEspera.Size = new System.Drawing.Size(145, 18);
            this.lblTiempodeEspera.TabIndex = 3;
            this.lblTiempodeEspera.Text = "Tiempo de Espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(181, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Intervalo Mensajes";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalo.Location = new System.Drawing.Point(188, 107);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(131, 29);
            this.txtIntervalo.TabIndex = 1;
            // 
            // cbxAleatorio
            // 
            this.cbxAleatorio.AutoSize = true;
            this.cbxAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAleatorio.ForeColor = System.Drawing.Color.Lime;
            this.cbxAleatorio.Location = new System.Drawing.Point(146, 179);
            this.cbxAleatorio.Name = "cbxAleatorio";
            this.cbxAleatorio.Size = new System.Drawing.Size(116, 29);
            this.cbxAleatorio.TabIndex = 3;
            this.cbxAleatorio.Text = "Aleatorio";
            this.cbxAleatorio.UseVisualStyleBackColor = true;
            // 
            // cbxIncluirFecha
            // 
            this.cbxIncluirFecha.AutoSize = true;
            this.cbxIncluirFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIncluirFecha.ForeColor = System.Drawing.Color.Lime;
            this.cbxIncluirFecha.Location = new System.Drawing.Point(281, 179);
            this.cbxIncluirFecha.Name = "cbxIncluirFecha";
            this.cbxIncluirFecha.Size = new System.Drawing.Size(154, 29);
            this.cbxIncluirFecha.TabIndex = 4;
            this.cbxIncluirFecha.Text = "Incluir Fecha";
            this.cbxIncluirFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxIncluirFecha.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(17, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 44);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Editar Lista";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvMensajes
            // 
            this.lvMensajes.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvMensajes.ForeColor = System.Drawing.SystemColors.Window;
            this.lvMensajes.HideSelection = false;
            this.lvMensajes.Location = new System.Drawing.Point(12, 279);
            this.lvMensajes.Name = "lvMensajes";
            this.lvMensajes.Size = new System.Drawing.Size(496, 151);
            this.lvMensajes.TabIndex = 9;
            this.lvMensajes.UseCompatibleStateImageBehavior = false;
            this.lvMensajes.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 106);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(337, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(354, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad de Vueltas";
            // 
            // txtCantMens
            // 
            this.txtCantMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantMens.Location = new System.Drawing.Point(357, 107);
            this.txtCantMens.Name = "txtCantMens";
            this.txtCantMens.Size = new System.Drawing.Size(131, 29);
            this.txtCantMens.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(525, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantMens);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvMensajes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxIncluirFecha);
            this.Controls.Add(this.cbxAleatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.lblTiempodeEspera);
            this.Controls.Add(this.txtTiempodeEspera);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensajes automaticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTiempodeEspera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.CheckBox cbxAleatorio;
        private System.Windows.Forms.CheckBox cbxIncluirFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvMensajes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantMens;
        public System.Windows.Forms.TextBox txtTiempodeEspera;
    }
}

