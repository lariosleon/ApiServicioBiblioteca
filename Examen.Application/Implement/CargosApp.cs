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
    public class CargosApp: ICargosApp
    {
        private readonly ICargosDom _ICargosDom;
        public CargosApp(ICargosDom ICargosDom)
        {
            this._ICargosDom = ICargosDom;
        }
        public async Task<IEnumerable<CargosENT>> Obtener(string conexion)
        {
            return await _ICargosDom.Obtener(conexion);
        }
    }
}
