using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Docente : Base
    {
        public List<Entidades.Docente> RecuperarTodos()
        {
            List<Entidades.Docente> docentes = new List<Entidades.Docente>();

            string query = "select * from Docentes";

            SqlCommand comando = new SqlCommand(query, conexion);

            try {
                conexion.Open();

                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Entidades.Docente docente = new Entidades.Docente();
                    docente.IdDocente = (int)dr["IdDocente"];
                    docente.Cuil = (string)dr["Cuil"];
                    docente.ApellidoNombre = (string)dr["ApellidoNombre"];
                    docente.Email = (string)dr["Email"];
                    docente.FechaIngreso = (DateTime)dr["FechaIngreso"];
                    docente.Salario = (decimal)dr["Salario"];

                    docentes.Add(docente);
                }
            }catch(Exception)
            {

            }
            finally
            {
                conexion.Close();
            }            

            return docentes;
        }

        public void Agregar(Entidades.Docente docente)
        {
            string query = "insert into Docentes values (@id, @cuil, @apellidonombre, @email, @fechaingreso, @salario)";

            SqlCommand comando = new SqlCommand(query, conexion);

            conexion.Open();

            comando.Parameters.AddWithValue("@id", docente.IdDocente);
            comando.Parameters.AddWithValue("@cuil", docente.Cuil);
            comando.Parameters.AddWithValue("@apellidonombre", docente.ApellidoNombre);
            comando.Parameters.AddWithValue("@email", docente.Email);
            comando.Parameters.AddWithValue("@fechaingreso", docente.FechaIngreso);
            comando.Parameters.AddWithValue("@salario", docente.Salario);

            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public Entidades.Docente RecuperarUno(string cuil)
        {
            List<Entidades.Docente> docentes = new List<Entidades.Docente>();

            Entidades.Docente docente = new Entidades.Docente();

            docente = docentes.First(d => d.Cuil == cuil);

            return docente;
        }
    }
}
