using Examen.Api.Data;
using Examen.Application.Interface;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {
        private readonly ICargosApp _cargos;
        string conexion = new ConexionDAO().GetCnx();
        public CargosController(ICargosApp CargosApp)
        {
            _cargos = CargosApp;
        }
        [HttpGet]
        public async Task<IEnumerable<CargosENT>> Get()
        {

            return await _cargos.Obtener(conexion);
        }
    }
}
