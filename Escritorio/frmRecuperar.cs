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
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text;

            Entidades.Docente docente = new Entidades.Docente();

            if (Negocio.Docente.esCuilValido(cuil))
            {
                docente = Negocio.Docente.RecuperarUno(cuil);
                lblId.Text += docente.IdDocente;
                lblCuil.Text += docente.Cuil;
                lblNombre.Text += docente.ApellidoNombre;
                lblEmail.Text += docente.Email;
                lblSalario.Text += docente.Salario;
                lblFechaIngreso.Text += docente.FechaIngreso;
                lblAntiguedad.Text += docente.Antiguedad;
            }
            else
            {
                MessageBox.Show("El cuil es invalido");
            }
        }
    }
}
