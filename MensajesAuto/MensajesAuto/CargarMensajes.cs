using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MensajesAuto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            try
            {

                using (StreamReader sr = File.OpenText("Mensajes.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lvMensajesCargados.Items.Add(line);
                    }
                }
            }
            catch (Exception)
            {


            }
           


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtMesajeAgregar.Text == "")
            {
                MessageBox.Show("Por favor ingrese el texto");
                txtMesajeAgregar.Focus();
            }
            else
            {

                int canMen = lvMensajesCargados.Items.Count;
                string mensaje = txtMesajeAgregar.Text;
                Mensaje mensaje1 = new Mensaje();
                mensaje1.idmensaje = canMen;
                mensaje1.mensaje = mensaje;


                lvMensajesCargados.Items.Insert(canMen, mensaje1.idmensaje + "_  " + mensaje1.mensaje);

                MessageBox.Show("Mensaje Cargado");
                txtMesajeAgregar.Text = "";
                txtMesajeAgregar.Focus();
            }

        }
        private List<string> crearlista() {
            List<string> items = new List<string>();
            foreach (ListViewItem item in lvMensajesCargados.Items)
            {
                items.Add(item.Text);
            }

            return items;

        }

        private void Guardar_a_archivo(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Mensajes.txt");

            foreach (string item in crearlista())
            {
                sw.WriteLine(item);
            }
            MessageBox.Show("Mensaje guardado");
            sw.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<string> itemschek = new List<string>();
            foreach (ListViewItem itemSelec in lvMensajesCargados.CheckedItems)
            {
                itemSelec.Remove();
            }
            
               
        }
    }
}
