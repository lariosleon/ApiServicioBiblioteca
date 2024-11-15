using Examen.Api.Data;
using Examen.Application.Interface;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudiantesApp _estudiantes;
        string conexion = new ConexionDAO().GetCnx();
        public EstudiantesController(IEstudiantesApp EstudiantesApp)
        {
            _estudiantes = EstudiantesApp;
        }
        [HttpGet]
        public async Task<IEnumerable<EstudiantesENT>> Get()
        {

            return await _estudiantes.Obtener(conexion);
        }
    }
}
