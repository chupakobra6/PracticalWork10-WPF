﻿using SunClouds.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AuthWindow authWindow;
        public static MainWindow mainWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            authWindow = new AuthWindow();
            authWindow.Show();
        }
    }
}
