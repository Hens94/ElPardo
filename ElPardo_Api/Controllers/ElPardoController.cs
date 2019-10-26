using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElPardo_Api.Contracts;
using ElPardo_Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElPardo_Api.Controllers
{
    [Route("api/[controller]")]
    public class ElPardoController : ControllerBase
    {
        private readonly IAcciones _acciones;

        public ElPardoController(IAcciones acciones)
        {
            _acciones = acciones;
        }

        [HttpGet]
        public IActionResult Get([FromBody] Balon balon)
        {
            (var deporte, var marca) = _acciones.JugarDeporteConBalon(balon);
            return new JsonResult(new { Deporte = deporte, Marca = marca });
        }
    }
}
