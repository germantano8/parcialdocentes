using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class Docente
    {
        static public List<Entidades.Docente> RecuperarTodos()
        {
            Datos.Docente datosDocente = new Datos.Docente();
            return datosDocente.RecuperarTodos();
        }

        static public Entidades.Docente RecuperarUno(string cuil)
        {
            if (esCuilValido(cuil)) 
            {
                Datos.Docente datosDocente = new Datos.Docente();
                return datosDocente.RecuperarUno(cuil);
            }

            throw new Exception("El cuil es inválido");
        }

        static public bool esCuilValido(string cuil)
        {            
            string patron = "^(20|27|30)([0-9]{9})$";

            if (Regex.IsMatch(cuil, patron))
            {
                return true;
            }

            return false;
        }
    }
}
