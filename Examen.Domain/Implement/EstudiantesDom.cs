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
    public class EstudiantesDom: IEstudiantesDom
    {
        private readonly IEstudiantesInf _IEstudiantesDat;
        public EstudiantesDom(IEstudiantesInf IEstudiantesDat)
        {
            this._IEstudiantesDat = IEstudiantesDat;
        }
        public async Task<IEnumerable<EstudiantesENT>> Obtener(string conexion)
        {
            return await _IEstudiantesDat.Obtener(conexion);
        }
    }
}
