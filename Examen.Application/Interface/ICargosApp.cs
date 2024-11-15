using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Application.Interface
{
    public interface ICargosApp
    {
        Task<IEnumerable<CargosENT>> Obtener(string conexion);
    }
}
