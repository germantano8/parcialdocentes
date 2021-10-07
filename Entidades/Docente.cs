using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente
    {
        public string ApellidoNombre { get; set; }
        public string Cuil { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdDocente { get; set; }
        public decimal Salario { get; set; }

        public int Antiguedad 
        {
            get 
            {
                return DateTime.Today.Subtract(FechaIngreso).Days;
            }
        }

        public Docente()
        {
            ApellidoNombre = string.Empty;
            Cuil = string.Empty;
            Email = string.Empty;
            FechaIngreso = DateTime.Today;
            IdDocente = 0;
            Salario = 0;
        }

        public Docente(string ApellidoNombre, string Cuil, string Email, DateTime FechaIngreso, int IdDocente, decimal Salario) 
        {
            this.ApellidoNombre = ApellidoNombre;
            this.Cuil = Cuil;
            this.Email = Email;
            this.FechaIngreso = FechaIngreso;
            this.IdDocente = IdDocente;
            this.Salario = Salario;
        }
    }
}
