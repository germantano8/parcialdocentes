using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListado Listado = new frmListado();
            
            Listado.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmRecuperar Recuperar = new frmRecuperar();

            Recuperar.ShowDialog();
        }
    }
}
