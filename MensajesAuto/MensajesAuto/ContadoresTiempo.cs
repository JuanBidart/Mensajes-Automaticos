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
    public partial class ContadoresTiempo : Form
    {
        public ContadoresTiempo()
        {
            InitializeComponent();
        
          
        }

        private void ContadoresTiempo_Load(object sender, EventArgs e)

        {
            Principal formprin = new Principal();

            lblsegres.Text = formprin.txtTiempodeEspera.Text;
           

            
        }
    }
}
