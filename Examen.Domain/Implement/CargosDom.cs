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
    public class CargosDom: ICargosDom
    {
        private readonly ICargosInf _ICargosDat;
        public CargosDom(ICargosInf ICargosDat)
        {
            this._ICargosDat = ICargosDat;
        }
        public async Task<IEnumerable<CargosENT>> Obtener(string conexion)
        {
            return await _ICargosDat.Obtener(conexion);
        }
    }
}
