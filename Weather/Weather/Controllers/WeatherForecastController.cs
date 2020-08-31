using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Weather.Dtos;

namespace Weather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getweatherbycity/{id}")]
        public async Task<ActionResult> GetWeatherByCity(string id)
        {

            //string json = _repo.GetWeatherByCity(id);
            //if (json == null || json == "null" || json == "[]" || json == "")
            //    return Ok("[]");
            
            List<WeatherFieldsDTO> json = new List<WeatherFieldsDTO>();
            WeatherFieldsDTO weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "31.42";
            weatherFields.lon = "73.08";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "306.36";
            weatherFields.mintemp = "16.5";
            weatherFields.maxtemp = "28.5";
            weatherFields.windspeed = "2.28";
            weatherFields.winddirection = "61";
            weatherFields.nextdayweather = "Clouds";
            weatherFields.city = "adelaide";
            json.Add(weatherFields);


            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "24.91";
            weatherFields.lon = "67.08";
            weatherFields.weather = "Haze";
            weatherFields.temp = "29";
            weatherFields.mintemp = "20.9";
            weatherFields.maxtemp = "29.1";
            weatherFields.windspeed = "5.1";
            weatherFields.winddirection = "250";
            weatherFields.nextdayweather = "Clouds";
            weatherFields.city = "brisbane";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "31.55";
            weatherFields.lon = "74.34";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "302.15";
            weatherFields.mintemp = "13.2";
            weatherFields.maxtemp = "28";
            weatherFields.windspeed = "2.35";
            weatherFields.winddirection = "98";
            weatherFields.nextdayweather = "Clouds";
            weatherFields.city = "canberra";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "33.71";
            weatherFields.lon = "73.13";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "302.79";
            weatherFields.mintemp = "24.8";
            weatherFields.maxtemp = "31.8";
            weatherFields.windspeed = "1.95";
            weatherFields.winddirection = "58";
            weatherFields.nextdayweather = "Clear";
            weatherFields.city = "darwin";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "30.2";
            weatherFields.lon = "67.01";
            weatherFields.weather = "Clear";
            weatherFields.temp = "297.22";
            weatherFields.mintemp = "11.9";
            weatherFields.maxtemp = "21.6";
            weatherFields.windspeed = "1.18";
            weatherFields.winddirection = "126";
            weatherFields.nextdayweather = "Clouds";
            weatherFields.city = "hobart";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "34.01";
            weatherFields.lon = "71.58";
            weatherFields.weather = "Haze";
            weatherFields.temp = "302.15";
            weatherFields.mintemp = "14.3";
            weatherFields.maxtemp = "25.9";
            weatherFields.windspeed = "2.1";
            weatherFields.winddirection = "180";
            weatherFields.nextdayweather = "Smoke";
            weatherFields.city = "melbourne";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "33.6";
            weatherFields.lon = "73.07";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "298.15";
            weatherFields.mintemp = "16.9";
            weatherFields.maxtemp = "31.6";
            weatherFields.windspeed = "1.73";
            weatherFields.winddirection = "70";
            weatherFields.nextdayweather = "Haze";
            weatherFields.city = "perth";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "32.51";
            weatherFields.lon = "74.54";
            weatherFields.weather = "Smoke";
            weatherFields.temp = "18.8";
            weatherFields.mintemp = "18.8";
            weatherFields.maxtemp = "26.4";
            weatherFields.windspeed = "1.68";
            weatherFields.winddirection = "43";
            weatherFields.nextdayweather = "Smoke";
            weatherFields.city = "sydney";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "32.08";
            weatherFields.lon = "72.67";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "24.3";
            weatherFields.mintemp = "24.3";
            weatherFields.maxtemp = "31.3";
            weatherFields.windspeed = "2.59";
            weatherFields.winddirection = "79";
            weatherFields.nextdayweather = "Haze";
            weatherFields.city = "townsville";
            json.Add(weatherFields);

            weatherFields = new WeatherFieldsDTO();
            weatherFields.lat = "29.4";
            weatherFields.lon = "71.68";
            weatherFields.weather = "Clouds";
            weatherFields.temp = "307.27";
            weatherFields.mintemp = "24";
            weatherFields.maxtemp = "31.9";
            weatherFields.windspeed = "0.81";
            weatherFields.winddirection = "217";
            weatherFields.nextdayweather = "Smoke";
            weatherFields.city = "weipa";
            json.Add(weatherFields);



            var weather = json.Where(s => s.city == id.ToLower()).ToList();
            string jsonValue = JsonConvert.SerializeObject(weather);
            return Ok(jsonValue);
        }
    }
}
