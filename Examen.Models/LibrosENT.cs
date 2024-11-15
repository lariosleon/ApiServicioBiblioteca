using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class LibrosENT
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Paginas { get; set; }
        public int Stock { get; set; }
        public int Categoria_id { get; set; }
        public int Autor_id { get; set; }
    }
}
