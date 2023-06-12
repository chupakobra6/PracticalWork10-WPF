using System.Windows;


namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Должна была быть передача данных в WeatherProvider
            /*            WeatherService.UseOpenMeteo();
                        WeatherService.MeasureConfiguration.Windspeed = SettingsService.Configuration.Wind;
                        WeatherService.MeasureConfiguration.Pressure = SettingsService.Configuration.Pressure;
                        WeatherService.MeasureConfiguration.PrecipitationSum = SettingsService.Configuration.Lenght;
                        WeatherService.MeasureConfiguration.Temperature = SettingsService.Configuration.Temperature;
                        ServiceManager.InternetConnectionService.HostName = WeatherService.ProviderDomain;*/
        }
    }
}
