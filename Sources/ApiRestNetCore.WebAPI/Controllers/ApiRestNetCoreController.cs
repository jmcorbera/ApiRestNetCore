using ApiRestNetCore.Business;
using ApiRestNetCore.Entities;
using ApiRestNetCore.WebAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiRestNetCore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiRestNetCoreController : ControllerBase
    {
        private readonly ILogger<ApiRestNetCoreController> _logger;
        private readonly IApplication<Person> _persona;

        public ApiRestNetCoreController(ILogger<ApiRestNetCoreController> logger, IApplication<Person> persona)
        {
            this._logger = logger;
            this._persona = persona;
        }

        [HttpGet("ObtenerPersona")]
        public IActionResult GetPerson()
        {
            return Ok(_persona.GetAll());
        }

        [HttpPost("GuardarPersona")]
        public IActionResult SavePerson(PersonDTO dto)
        {
            var p = (new Person()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName
            });

            return Ok(_persona.Save(p));
        }
    }
}
