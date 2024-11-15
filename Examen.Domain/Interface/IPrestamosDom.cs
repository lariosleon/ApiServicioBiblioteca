using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interface
{
    public interface IPrestamosDom
    {
        Task<IEnumerable<PrestamosENT>> Obtener(string conexion);
        Task<Respuesta<PrestamosENT>> Insertar(string conexion, PrestamosENT model);
        Task<Respuesta<PrestamosENT>> Modificar(string conexion, PrestamosENT model);
        Task<PrestamosENT> ObtenerById(string conexion, int Id);
        Task<Respuesta<PrestamosENT>> eliminar(string conexion, int Id);
    }
}
