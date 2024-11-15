using Examen.Api.Data;
using Examen.Application.Implement;
using Examen.Application.Interface;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadoApp _empleados;
        string conexion = new ConexionDAO().GetCnx();
        public EmpleadosController(IEmpleadoApp CargosApp)
        {
            _empleados = CargosApp;
        }
        [HttpGet]
        public async Task<IEnumerable<EmpleadosENT>> Get()
        {

            return await _empleados.Obtener(conexion);
        }
    }
}
