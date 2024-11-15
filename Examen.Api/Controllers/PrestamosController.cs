using Examen.Api.Data;
using Examen.Application.Interface;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private readonly IPrestamosApp _prestamos;
        string conexion = new ConexionDAO().GetCnx();
        public PrestamosController(IPrestamosApp PrestamosApp)
        {
            _prestamos = PrestamosApp;
        }
        [HttpGet]
        public async Task<IEnumerable<PrestamosENT>> Get()
        {

            return await _prestamos.Obtener(conexion);
        }
        [HttpPost]
        public async Task<Respuesta<PrestamosENT>> Post(PrestamosENT model)
        {
            return await _prestamos.Insertar(conexion, model);
        }
        [HttpPut]
        public async Task<Respuesta<PrestamosENT>> Put(PrestamosENT model)
        {
            return await _prestamos.Modificar(conexion, model);
        }
        [HttpGet("{id}")]
        public async Task<PrestamosENT> Get(int id)
        {
            return await _prestamos.ObtenerById(conexion, id);
        }
        [HttpDelete("{id}")]
        public async Task<Respuesta<PrestamosENT>> eliminar(int id)
        {
            return await _prestamos.eliminar(conexion, id);
        }
    }
}
