using SunClouds.ViewModel.Helpers;


namespace SunClouds.ViewModel
{
    internal class WeatherViewModel: BindingHelper
    {
        private string _feelsLike;
        private string _minTemperature;
        private string _maxTemperature;
        private string _pressure;
        private string _humidity;
        private string _windSpeed;
        private string _windDirection;

        public string FeelsLike
        {
            get { return _feelsLike; }
            set { _feelsLike = value; OnPropertyChanged(); }
        }

        public string MinTemperature
        {
            get { return _minTemperature; }
            set { _minTemperature = value; OnPropertyChanged(); }
        }
        public string MaxTemperature
        {
            get { return _maxTemperature; }
            set { _maxTemperature = value; OnPropertyChanged(); }
        }

        public string Pressure
        {
            get { return _pressure; }
            set { _pressure = value; OnPropertyChanged(); }
        }

        public string Humidity
        {
            get { return _humidity; }
            set { _humidity = value; OnPropertyChanged(); }
        }

        public string WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; OnPropertyChanged(); }
        }

        public string WindDirection
        {
            get { return _windDirection; }
            set { _windDirection = value; OnPropertyChanged(); }
        }
    }
}
