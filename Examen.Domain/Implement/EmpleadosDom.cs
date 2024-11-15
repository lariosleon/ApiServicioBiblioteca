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
    public class EmpleadosDom: IEmpleadosDom
    {
        private readonly IEmpleadosInf _IEmpleadosDat;
        public EmpleadosDom(IEmpleadosInf IEmpleadosDat)
        {
            this._IEmpleadosDat = IEmpleadosDat;
        }
        public async Task<IEnumerable<EmpleadosENT>> Obtener(string conexion)
        {
            return await _IEmpleadosDat.Obtener(conexion);
        }
    }
}
