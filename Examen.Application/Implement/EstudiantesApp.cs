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
   public class EstudiantesApp: IEstudiantesApp
    {
        private readonly IEstudiantesDom _IEstudiantesDom;
        public EstudiantesApp(IEstudiantesDom IEstudiantesDom)
        {
            this._IEstudiantesDom = IEstudiantesDom;
        }
        public async Task<IEnumerable<EstudiantesENT>> Obtener(string conexion)
        {
            return await _IEstudiantesDom.Obtener(conexion);
        }
    }
}
