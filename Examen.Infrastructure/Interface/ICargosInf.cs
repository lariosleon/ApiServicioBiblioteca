using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Interface
{
    public interface ICargosInf
    {
        Task<IEnumerable<CargosENT>> Obtener(string conexion);
    }
}
