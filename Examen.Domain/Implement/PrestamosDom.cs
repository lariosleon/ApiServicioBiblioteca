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
    public class PrestamosDom: IPrestamosDom
    {
        private readonly IPrestamosInf _IPrestamosDat;
        public PrestamosDom(IPrestamosInf IPrestamosDat)
        {
            this._IPrestamosDat = IPrestamosDat;
        }
        public async Task<IEnumerable<PrestamosENT>> Obtener(string conexion)
        {
            return await _IPrestamosDat.Obtener(conexion);
        }
        public async Task<Respuesta<PrestamosENT>> Insertar(string conexion, PrestamosENT model)
        {
            return await _IPrestamosDat.Insertar(conexion, model);
        }
        public async Task<Respuesta<PrestamosENT>> Modificar(string conexion, PrestamosENT model)
        {
            return await _IPrestamosDat.Modificar(conexion, model);
        }
        public async Task<PrestamosENT> ObtenerById(string conexion, int Id)
        {
            return await _IPrestamosDat.ObtenerById(conexion, Id);
        }
        public async Task<Respuesta<PrestamosENT>> eliminar(string conexion, int Id)
        {
            return await _IPrestamosDat.eliminar(conexion, Id);
        }
    }
}
