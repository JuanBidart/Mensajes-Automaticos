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

            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 Cargarmensaje = new Form2();
            Cargarmensaje.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
