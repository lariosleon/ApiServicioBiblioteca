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
    public class LibrosInf: ILibrosInf
    {
        public async Task<IEnumerable<LibrosENT>> Obtener(string conexion)
        {

            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtener_libros", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItems(reader);
        }
        static async Task<IEnumerable<LibrosENT>> ReadItems(DbDataReader reader)
        {
            IList<LibrosENT> lista = new List<LibrosENT>();
            while (await reader.ReadAsync())
            {
                LibrosENT obj = new LibrosENT()
                {
                    Id = reader.GetFieldValue<int>(0),
                    Nombre = reader["Nombre"].ToString(),
                    Paginas = Convert.ToInt32(reader["Paginas"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Categoria_id = Convert.ToInt32(reader["Categoria_id"]),
                    Autor_id = Convert.ToInt32(reader["autor_id"])
                };
                lista.Add(obj);
            }
            return lista;
        }
    }
}
