using Examen.Application.Interface;
using Examen.Domain.Implement;
using Examen.Domain.Interface;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Application.Implement
{
    public class PrestamosApp: IPrestamosApp
    {
        private readonly IPrestamosDom _IPrestamosDom;
        public PrestamosApp(IPrestamosDom IPrestamosDom)
        {
            this._IPrestamosDom = IPrestamosDom;
        }
        public async Task<IEnumerable<PrestamosENT>> Obtener(string conexion)
        {
            return await _IPrestamosDom.Obtener(conexion);
        }
        public async Task<Respuesta<PrestamosENT>> Insertar(string conexion, PrestamosENT model)
        {
            return await _IPrestamosDom.Insertar(conexion, model);
        }
        public async Task<Respuesta<PrestamosENT>> Modificar(string conexion, PrestamosENT model)
        {
            return await _IPrestamosDom.Modificar(conexion, model);
        }
        public async Task<PrestamosENT> ObtenerById(string conexion, int Id)
        {
            return await _IPrestamosDom.ObtenerById(conexion, Id);
        }
        public async Task<Respuesta<PrestamosENT>> eliminar(string conexion, int Id)
        {
            return await _IPrestamosDom.eliminar(conexion, Id);
        }
    }
}
