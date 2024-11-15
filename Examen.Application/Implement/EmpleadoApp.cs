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
    public class EmpleadoApp: IEmpleadoApp
    {
        private readonly IEmpleadosDom _IEmpleadoDom;
        public EmpleadoApp(IEmpleadosDom IEmpleadoDom)
        {
            this._IEmpleadoDom = IEmpleadoDom;
        }
        public async Task<IEnumerable<EmpleadosENT>> Obtener(string conexion)
        {
            return await _IEmpleadoDom.Obtener(conexion);
        }
    }
}
