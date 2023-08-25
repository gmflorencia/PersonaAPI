using PrimerEjercicio.Models;
using System.Collections.Generic;

namespace PrimerEjercicio.Data
{
    public class WeatherForecastRepository
    {
        private readonly List<WeatherForecast> _repository = new List<WeatherForecast>();

        public WeatherForecastRepository()
        {
            // Llenar la lista con algunas tareas de ejemplo en el constructor
            AddWeatherForecast(new WeatherForecast { Id = 1 });
            AddWeatherForecast(new WeatherForecast { Id = 2 });
            AddWeatherForecast(new WeatherForecast { Id = 3 });
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _repository;
        }
        public IEnumerable<WeatherForecast> GetAllById()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        public void AddWeatherForecast(WeatherForecast weatherForecast)
        {
            weatherForecast.Id = 1;
            _repository.Add(weatherForecast);
        }
    }
}
