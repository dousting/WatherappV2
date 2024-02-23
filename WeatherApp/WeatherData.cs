using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherData
    {
        public MainData Main { get; set; }
        public List<WeatherDescription> WeatherDescriptions { get; set; }

        public class MainData
        {
            public double Temp { get; set; }
        }

        public class WeatherDescription
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }
    }
}