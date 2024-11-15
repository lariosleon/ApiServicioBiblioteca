using Examen.Domain.Interface;
using Examen.Infrastructure.Interface;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Implement
{
    public class LibrosDom: ILibrosDom
    {
        private readonly ILibrosInf _ILibrosDat;
        public LibrosDom(ILibrosInf ILibrosDat)
        {
            this._ILibrosDat = ILibrosDat;
        }
        public async Task<IEnumerable<LibrosENT>> Obtener(string conexion)
        {
            return await _ILibrosDat.Obtener(conexion);
        }
    }
}
