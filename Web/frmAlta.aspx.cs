using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frmAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuil.Text = "";
            txtId.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtSalario.Text = "";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            List<string> campos = new List<string> {
                txtCuil.Text,
                txtId.Text,
                txtEmail.Text,
                txtNombre.Text,
                txtSalario.Text,
            };

            if (Negocio.Validaciones.esCuilValido(txtCuil.Text) && Negocio.Validaciones.isNotEmpty(campos))
            {
                Entidades.Docente docente = new Entidades.Docente {
                    Cuil = txtCuil.Text,
                    IdDocente = int.Parse(txtId.Text),
                    Email = txtEmail.Text,
                    ApellidoNombre = txtNombre.Text,
                    Salario = decimal.Parse(txtSalario.Text),
                    FechaIngreso = calendar.SelectedDate,
                };

                Negocio.Docente.Agregar(docente);
                lblConfirma.Text = "Datos guardados correctamente";
            }
            else
            {
                lblConfirma.Text = "Rellene todos los campos correctamente";
            }
        }
    }
}