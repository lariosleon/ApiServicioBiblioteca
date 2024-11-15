using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interface
{
    public interface IEstudiantesDom
    {
        Task<IEnumerable<EstudiantesENT>> Obtener(string conexion);
    }
}
