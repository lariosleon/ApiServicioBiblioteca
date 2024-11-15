using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class PrestamosENT
    {
        public int Id { get; set; }
        public string? Empleado { get; set; }
        public int empleado_id { get; set; }
        public string? Estudiantes { get; set; }
        public int estudiante_id { get; set; }
        public string? Libro { get; set; }
        public int Libro_id { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string? estado { get; set; }
        public DateTime Fecha_Retorno { get; set; }
    }
}
