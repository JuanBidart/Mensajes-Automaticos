using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MensajesAuto
{

    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            label1.Text = fecha.ToShortDateString();
            using (StreamReader sr = File.OpenText("Mensajes.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lvMensajes.Items.Add(line);
                }


            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 Cargarmensaje = new Form2();
            Cargarmensaje.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (txtCantMens.Text==""||txtIntervalo.Text==""||txtTiempodeEspera.Text=="")
            {
                MessageBox.Show("Verifique y cargue los numeros correctos");
                txtTiempodeEspera.Focus();
            }
            else {
                try
                {
                    int intervaloMen = int.Parse(txtIntervalo.Text);
                    int cantidadMensaje = int.Parse(txtCantMens.Text);
                    int espera = int.Parse(txtTiempodeEspera.Text);
                    
                    
                    ventanaContador(true);
                    Thread.Sleep(espera * 1000);
                    
                    
                    List<string> lista = new List<string>();
                    foreach (ListViewItem item in lvMensajes.Items)
                    {
                        lista.Add(item.Text);

                    }
                    for (int i = 0; i < cantidadMensaje; i++)
                    {

                        foreach (string lineas in lista)
                        {
                            SendKeys.SendWait(lineas.Substring(3));
                            SendKeys.SendWait("{ENTER}");
                            Thread.Sleep(intervaloMen * 1000);
                        }
                    }
                    MessageBox.Show("Tarea Terminada", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }
        }
        
   
        private void ventanaContador(bool estado) { 
        ContadoresTiempo ventanacontador = new ContadoresTiempo();
            if (estado == true )
            {
                ventanacontador.ShowDialog();
            }else ventanacontador.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvMensajes.Clear();
            using (StreamReader sr = File.OpenText("Mensajes.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lvMensajes.Items.Add(line);
                }
                sr.Close();

            }
        }
    }
}
