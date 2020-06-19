using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return StatusCode(500, new { message = "Não Implementado" });
        }

        [HttpPut]
        public IActionResult Put()
        {
            return StatusCode(500, new { message = "Não Implementado" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return StatusCode(500, new { message = "Não implementado." });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return StatusCode(500, new { message = "Não implementado." });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return StatusCode(500, new { message = "Não implementado." });
        }
    }
}