using Examen.Application.Interface;
using Examen.Domain.Interface;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Application.Implement
{
    public class LibrosApp : ILibrosApp
    {
        private readonly ILibrosDom _ILibrosDom;
        public LibrosApp(ILibrosDom ILibrosDom)
        {
            this._ILibrosDom = ILibrosDom;
        }
        public async Task<IEnumerable<LibrosENT>> Obtener(string conexion)
        {
            return await _ILibrosDom.Obtener(conexion);
        }
    }
}
