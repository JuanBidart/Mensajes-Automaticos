using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensajesAuto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtMesajeAgregar.Text == "")
            {
                MessageBox.Show("Por favor ingrese el texto");
            }
            else
            {

                int canMen = lvMensajesCargados.Items.Count;
                string mensaje = txtMesajeAgregar.Text;
                Mensaje mensaje1 = new Mensaje();
                mensaje1.idmensaje = canMen;
                mensaje1.mensaje = mensaje;


                lvMensajesCargados.Items.Insert(canMen, mensaje1.idmensaje +"_"+ mensaje1.mensaje );

               // MessageBox.Show("Mensaje Cargado");
                txtMesajeAgregar.Text = "";
                txtMesajeAgregar.Focus();
            }

        }
    }
}
