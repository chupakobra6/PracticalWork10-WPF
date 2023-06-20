using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.Model
{
    internal class WeatherWith4parametr
    {
        public float feelslike { get; set; }
        public double pressure { get; set; }
        public float temperature { get; set; }
        public int Hours { get; set; }
        public WeatherWith4parametr(int Hours, float feelslike, double pressure, float temperature) {
            this.feelslike = feelslike;
            this.pressure = pressure;
            this.temperature = temperature;
            this.Hours = Convert.ToInt32(Hours);
        }
    }
}
