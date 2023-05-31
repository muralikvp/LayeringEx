using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL
{
    public interface IWeatherRepository
    {
        IEnumerable<WeatherForecast> Get(string cityName, int numberOdDays);
    }
}
