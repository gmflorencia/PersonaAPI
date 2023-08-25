using PrimerEjercicio.Data;
using PrimerEjercicio.Models;

namespace PrimerEjercicio.Services
{
    public class WeatherForecastService
    {
        private readonly WeatherForecastRepository _repository;
        public WeatherForecastService(WeatherForecastRepository Repository)
        {
            _repository = Repository;
        }
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _repository.GetAll();
        }
        public void AddWeatherForecast(WeatherForecast weatherForecast)
        {
            _repository.AddWeatherForecast(weatherForecast);
        }
    }
}
