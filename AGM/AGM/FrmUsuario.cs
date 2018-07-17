using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGM
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal res = new Principal();
            res.Show();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
