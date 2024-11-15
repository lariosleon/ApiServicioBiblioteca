using Examen.Infrastructure.Interface;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Implement
{
    public class EstudiantesInf: IEstudiantesInf
    {
        public async Task<IEnumerable<EstudiantesENT>> Obtener(string conexion)
        {

            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtener_estudiantes", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItems(reader);
        }
        static async Task<IEnumerable<EstudiantesENT>> ReadItems(DbDataReader reader)
        {
            IList<EstudiantesENT> lista = new List<EstudiantesENT>();
            while (await reader.ReadAsync())
            {
                EstudiantesENT obj = new EstudiantesENT()
                {
                    Id = reader.GetFieldValue<int>(0),
                    Nombre = reader["Nombre"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Direccion = reader["Direccion"].ToString(),
                };
                lista.Add(obj);
            }
            return lista;
        }
    }
}
