using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays);
    }

    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository repository;

        public WeatherService(IWeatherRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<WeatherForecast> Get(string cityName, int numberOfDays)
        {
            return repository.Get(cityName, numberOfDays);
        }
    }
}
