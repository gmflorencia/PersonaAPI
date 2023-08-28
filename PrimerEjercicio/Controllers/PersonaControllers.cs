using Microsoft.AspNetCore.Mvc;
using PrimerEjercicio.Models;
using PrimerEjercicio.Services;
using System.Collections.Generic;

namespace PrimerEjercicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {

        private readonly ILogger<PersonaController> _logger;
        private readonly PersonaService _service;

        public PersonaController(ILogger<PersonaController> logger, PersonaService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetPersona")]
        public IEnumerable<Persona> Get()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return _service.GetAll();

        }
        [HttpPost]
        public IActionResult CreatePersona(Persona persona)
        {
            _service.AddPersona(persona);
            //return CreatedAtAction(nameof(GetPersona), new { id = persona.Id }, persona);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePersona(int id, Persona persona)
        {
            if (id != persona.Id)
            {
                return BadRequest();
            }
            _service.UpdatePersona(persona);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePersona(int id)
        {
            _service.DeletePersona(id);
            return NoContent();
        }
    }
}