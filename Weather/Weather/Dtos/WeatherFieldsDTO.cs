using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Dtos
{
    public class WeatherFieldsDTO
    {
        public string lat { get; set; }
        public string lon { get; set; }
        public string weather { get; set; }
        public string temp { get; set; }
        public string maxtemp { get; set; }
        public string mintemp { get; set; }
        public string windspeed { get; set; }
        public string winddirection { get; set; }
        public string city { get; set; }
        public string nextdayweather { get; set; }
    }
}
