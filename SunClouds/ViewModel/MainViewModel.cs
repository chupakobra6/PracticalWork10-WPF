using SunClouds.ViewModel.Helpers;
using SunClouds.View;
using System.ComponentModel;
using OpenMeteo;
using System.Threading.Tasks;
using System;
using SunClouds.Properties;

namespace SunClouds.ViewModel
{
    internal class MainViewModel : BindingHelper // Для команд
    {
        #region Properties (свойства) // Регионы для читабельности кода
        #endregion
        #region Commands (команды)
        #endregion
        #region Events (события)
        #endregion

        private string weathercodeTemperature;
        private string weathercodeTemperature2;
        private string weathercodeTemperature3;

        private string apparentTemperature;
        private string apparentTemperature2;
        private string apparentTemperature3;

        private string time;
        private string time2;
        private string time3;

        private string icon;
        private string icon2;
        private string icon3;

      

        public string WeathercodeTemperature
        {
            get { return weathercodeTemperature; }
            set
            {
                weathercodeTemperature = value;
                OnPropertyChanged("WeathercodeTemperature");
            }
        }
        public string WeathercodeTemperature2
        {
            get { return weathercodeTemperature2; }
            set
            {
                weathercodeTemperature2 = value;
                OnPropertyChanged("WeathercodeTemperature2");
            }
        }
        public string WeathercodeTemperature3
        {
            get { return weathercodeTemperature3; }
            set
            {
                weathercodeTemperature3 = value;
                OnPropertyChanged("WeathercodeTemperature3");
            }
        }

        public string ApparentTemperature
        {
            get { return apparentTemperature; }
            set
            {
                apparentTemperature = value;
                OnPropertyChanged("ApparentTemperature");
            }
        }
        public string ApparentTemperature2
        {
            get { return apparentTemperature2; }
            set
            {
                apparentTemperature2 = value;
                OnPropertyChanged("ApparentTemperature2");
            }
        }

        public string ApparentTemperature3
        {
            get { return apparentTemperature3; }
            set
            {
                apparentTemperature3 = value;
                OnPropertyChanged("ApparentTemperature3");
            }
        }

        public string Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }

        public string Time2
        {
            get { return time2; }
            set
            {
                time2 = value;
                OnPropertyChanged("Time2");
            }
        }

        public string Time3
        {
            get { return time3; }
            set
            {
                time3 = value;
                OnPropertyChanged("Time3");
            }
        }

        public string Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public string Icon2
        {
            get { return icon2; }
            set
            {
                icon2 = value;
                OnPropertyChanged("Icon2");
            }
        }

        public string Icon3
        {
            get { return icon3; }
            set
            {
                icon3 = value;
                OnPropertyChanged("Icon3");
            }
        }


        public MainViewModel()
        {
            Task.Run(async () => await RunAsync()).GetAwaiter().GetResult();
        }

        public async Task RunAsync()
        {
            OpenMeteoClient client = new OpenMeteoClient();   //Заменить заглушку на город
            WeatherForecast weatherData = await client.QueryAsync("Moscow");
            string weatherCode = client.WeathercodeToString((int)weatherData.Daily.Weathercode[0]) + "." + " " + weatherData.Hourly.Temperature_2m[0].ToString();
            string weatherCode2 = client.WeathercodeToString((int)weatherData.Daily.Weathercode[1]) + "." + " " + weatherData.Hourly.Temperature_2m[1].ToString();
            string weatherCode3 = client.WeathercodeToString((int)weatherData.Daily.Weathercode[2]) + "." + " " + weatherData.Hourly.Temperature_2m[2].ToString();

            /* (int)weatherData.Daily.Weathercode[0], (int)weatherData.Daily.Weathercode[1], (int)weatherData.Daily.Weathercode[2]
             * построить проверку для каждого
             * 
             */


            string Apparent_temperature = "Ощущается как " + weatherData.Hourly.Apparent_temperature[0].ToString();
            string Apparent_temperature2 = "Ощущается как " + weatherData.Hourly.Apparent_temperature[1].ToString();
            string Apparent_temperature3 = "Ощущается как " + weatherData.Hourly.Apparent_temperature[2].ToString();


            DateTime dt = DateTime.Parse(weatherData.CurrentWeather.Time);
            string time = dt.ToString("HH:mm");
            string time2 = dt.AddHours(1).ToString("HH:mm");
            string time3 = dt.AddHours(2).ToString("HH:mm");




            WeathercodeTemperature = weatherCode;
            WeathercodeTemperature2 = weatherCode2;
            WeathercodeTemperature3 = weatherCode3;
            ApparentTemperature = Apparent_temperature;
            ApparentTemperature2 = Apparent_temperature2;
            ApparentTemperature3 = Apparent_temperature3;
            Time = time;
            Time2 = time2;
            Time3 = time3;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

