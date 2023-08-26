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
    }
}