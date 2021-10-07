using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            Datos.Docente datosDocente = new Datos.Docente();
            return datosDocente.RecuperarUno(cuil);
        }
    }
}
