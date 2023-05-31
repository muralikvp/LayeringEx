using Layer.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.DAL
{

    public class WeatherRepository : IWeatherRepository
    {
            private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        private static IEnumerable<WeatherForeCastDto> GetDummyData(int numberOdDays)
        {
            return Enumerable.Range(1, numberOdDays).Select(index => new WeatherForeCastDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Temperature = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        IEnumerable<WeatherForecast> IWeatherRepository.Get(string cityName, int numberOdDays)
        {
            return GetDummyData(numberOdDays).Select(dto => new WeatherForecast()
            {
                Date = dto.Date,
                Summary = dto.Summary,
                TemperatureC = dto.Temperature
            }).ToArray();
        }
    }

}
