using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.Model
{
    public class WeatherInfoConvert
    {


        public string GetTemperature(int value)
        {
            return $"{value}°";
        }

        
        public string GetPressure(int value)
        {
            return $"{value} мм рт. ст.";
        }

        public string GetHumidity(int value)
        {
            return $"{value}%";
        }

        public string GetWindSpeed(int value)
        {
            return $"{value} м/с";
        }

        public string GetWindDirection(int value)
        {
            return $"{value}";
        }
    }
}
