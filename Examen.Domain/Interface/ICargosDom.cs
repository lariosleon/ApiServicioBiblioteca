﻿using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interface
{
    public interface ICargosDom
    {
        Task<IEnumerable<CargosENT>> Obtener(string conexion);
    }
}
