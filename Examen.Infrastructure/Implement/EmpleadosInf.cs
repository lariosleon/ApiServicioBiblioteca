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
    public class EmpleadosInf: IEmpleadosInf
    {
        public async Task<IEnumerable<EmpleadosENT>> Obtener(string conexion)
        {

            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtener_empleados", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItems(reader);
        }
        static async Task<IEnumerable<EmpleadosENT>> ReadItems(DbDataReader reader)
        {
            IList<EmpleadosENT> lista = new List<EmpleadosENT>();
            while (await reader.ReadAsync())
            {
                EmpleadosENT obj = new EmpleadosENT()
                {
                    Id = reader.GetFieldValue<int>(0),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Cedula = reader["Cedula"].ToString(),
                    Cargo_id = Convert.ToInt32(reader["Cargo_id"])

                };
                lista.Add(obj);
            }
            return lista;
        }
    }
}
