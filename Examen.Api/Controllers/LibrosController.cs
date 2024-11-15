using Examen.Api.Data;
using Examen.Application.Interface;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ILibrosApp _libros;
        string conexion = new ConexionDAO().GetCnx();
        public LibrosController(ILibrosApp LibrosApp)
        {
            _libros = LibrosApp;
        }
        [HttpGet]
        public async Task<IEnumerable<LibrosENT>> Get()
        {

            return await _libros.Obtener(conexion);
        }
    }
}
