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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal  res = new Principal ();
            res.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manteniminetoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal res = new Principal();
            res.Show();
        }

        private void mantenimientosProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal res = new Principal();
            res.Show();
        }

        private void mantenimientoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal res = new Principal();
            res.Show();
        }
    }
}
