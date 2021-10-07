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

            try
            {
                docente = Negocio.Docente.RecuperarUno(cuil);
                lblId.Text = $"ID: {docente.IdDocente}";
                lblCuil.Text = $"Cuil: {docente.Cuil}";
                lblNombre.Text = $"Nombre: {docente.ApellidoNombre}";
                lblEmail.Text = $"Email: {docente.Email}";
                lblSalario.Text = $"Salario: {docente.Salario}";
                lblFechaIngreso.Text = $"Fecha de ingreso: {docente.FechaIngreso}";
                lblAntiguedad.Text = $"Antiguedad: {docente.Antiguedad} años";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
