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
    public class PrestamosInf: IPrestamosInf
    {
        public async Task<IEnumerable<PrestamosENT>> Obtener(string conexion)
        {

            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtener_prestamos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItems(reader);
        }
        static async Task<IEnumerable<PrestamosENT>> ReadItems(DbDataReader reader)
        {
            IList<PrestamosENT> lista = new List<PrestamosENT>();
            while (await reader.ReadAsync())
            {
                PrestamosENT obj = new PrestamosENT()
                {
                    Id = reader.GetFieldValue<int>(0),
                    Empleado = reader["Empleado"].ToString(),
                    Estudiantes = reader["Estudiantes"].ToString(),
                    Libro = reader["Libro"].ToString(),
                    Fecha_Inicio = Convert.ToDateTime(reader["Fecha_inicio"]),
                    Fecha_Fin = Convert.ToDateTime(reader["Fecha_fin"]),
                    estado = reader["estado"].ToString(),
    
                };
                lista.Add(obj);
            }
            return lista;
        }

        public async Task<Respuesta<PrestamosENT>> Insertar(string conexion, PrestamosENT model)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_insertar_prestamos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("empleado_id", model.empleado_id);
            cmd.Parameters.AddWithValue("estudiante_id", model.estudiante_id);
            cmd.Parameters.AddWithValue("libro_id", model.Libro_id);
            cmd.Parameters.AddWithValue("Fecha_Inicio", model.Fecha_Inicio);
            cmd.Parameters.AddWithValue("Fecha_Fin", model.Fecha_Fin);
            cmd.Parameters.AddWithValue("estado", model.estado);
            cmd.Parameters.AddWithValue("Fecha_Retorno", model.Fecha_Retorno);

            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItem(reader);
        }
        static async Task<Respuesta<PrestamosENT>> ReadItem(DbDataReader reader)
        {
            Respuesta<PrestamosENT> obj = new Respuesta<PrestamosENT>
            {
                Response = new PrestamosENT()
            };
            while (await reader.ReadAsync())
            {
                obj.Exito = Convert.ToBoolean(reader["Exito"]);
                obj.Mensaje = Convert.ToString(reader["Mensaje"]);
                obj.Response.Id = Convert.ToInt32(reader["Id"]);
                obj.Response.Empleado = Convert.ToString(reader["Empleado"]);
                obj.Response.Estudiantes = Convert.ToString(reader["Estudiantes"]);
                obj.Response.Libro = Convert.ToString(reader["Libro"]);
                obj.Response.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]);

            }
            return obj;
        }
        public async Task<Respuesta<PrestamosENT>> Modificar(string conexion, PrestamosENT model)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_modificar_prestamos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("Id", model.Id);
             cmd.Parameters.AddWithValue("empleado_id", model.empleado_id);
            cmd.Parameters.AddWithValue("estudiante_id", model.estudiante_id);
            cmd.Parameters.AddWithValue("libro_id", model.Libro_id);
            cmd.Parameters.AddWithValue("Fecha_Inicio", model.Fecha_Inicio);
            cmd.Parameters.AddWithValue("Fecha_Fin", model.Fecha_Fin);
            cmd.Parameters.AddWithValue("estado", model.estado);
            cmd.Parameters.AddWithValue("Fecha_Retorno", model.Fecha_Retorno);
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItem(reader);
        }
        public async Task<PrestamosENT> ObtenerById(string conexion, int Id)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_obtenerbyid_prestamos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("Id", Id);
            var reader = await cmd.ExecuteReaderAsync();
            return await Read(reader);
        }
        static async Task<PrestamosENT> Read(DbDataReader reader)
        {
            PrestamosENT obj = new PrestamosENT();
            while (await reader.ReadAsync())
            {
                obj.Id = Convert.ToInt32(reader["Id"]);
                obj.empleado_id = Convert.ToInt32(reader["empleado_id"]);
                obj.estudiante_id = Convert.ToInt32(reader["estudiante_id"]);
                obj.Libro_id = Convert.ToInt32(reader["Libro_id"]);
                obj.Fecha_Inicio = Convert.ToDateTime(reader["Fecha_Inicio"]);
                obj.Fecha_Fin = Convert.ToDateTime(reader["Fecha_Fin"]);
                obj.estado = Convert.ToString(reader["estado"]);
                obj.Fecha_Retorno = Convert.ToDateTime(reader["Fecha_Retorno"]);
            }
            return obj;
        }
        public async Task<Respuesta<PrestamosENT>> eliminar(string conexion, int Id)
        {
            using SqlConnection conn = new SqlConnection(conexion);
            await conn.OpenAsync();
            using SqlCommand cmd = new SqlCommand("sp_eliminar_prestamos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("Id", Id);
            var reader = await cmd.ExecuteReaderAsync();
            return await ReadItem(reader);
        }
    }
}
