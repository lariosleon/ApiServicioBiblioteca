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
    public class CargosInf: ICargosInf
    {
        public async Task<IEnumerable<CargosENT>> Obtener(string conexion)
        {

            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtener_cargos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItems(reader);
        }

        static async Task<IEnumerable<CargosENT>> ReadItems(DbDataReader reader)
        {
            IList<CargosENT> lista = new List<CargosENT>();
            while (await reader.ReadAsync())
            {
                CargosENT obj = new CargosENT()
                {
                    Id = reader.GetFieldValue<int>(0),
                    Nombre = reader["Nombre"].ToString(),
                };
                lista.Add(obj);
            }
            return lista;
        }
    }
}
