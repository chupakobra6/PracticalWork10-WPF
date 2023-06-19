﻿using OpenMeteo;
using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SunClouds.ViewModel
{
    internal class AuthViewModel : BindingHelper
    {
        private string _city;
        private bool Oke = false;
        public string City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged(); }
        }
        public BindableCommand Autorization { get; set; }
        public AuthViewModel()
        {
            Autorization = new BindableCommand(_ => AutorizationCheck());
        }
        private void AutorizationCheck()
        {
            Task.Run(async () => await RunAsync()).GetAwaiter().GetResult();
            if (City != null && City.Length > 0)
            {
                if (Oke)
                {
                    SunClouds.Properties.Settings.Default.CurrentCity = City;
                    App.mainWindow = new MainWindow();
                    App.mainWindow.Show();
                    App.authWindow.Close();
                }
                else
                {
                    MessageBox.Show("Такого города не существует");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
        public async Task RunAsync()
        {
                OpenMeteoClient client = new OpenMeteoClient();
                WeatherForecast weatherData = await client.QueryAsync(City);
                if (weatherData != null)
                {
                    Oke = true;
                }
        }
    }
}
