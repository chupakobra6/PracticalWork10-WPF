using PracticalWork8.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SunClouds.ViewModel
{
    internal class AuthViewModel: BindingHelper
    {
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value;OnPropertyChanged(); }
        }
        public BindableCommand Autorization { get; set; }
        public AuthViewModel() {
            Autorization = new BindableCommand(_ => AutorizationCheck());
        }
        private void AutorizationCheck()
        {
            if(City != null && City.Length > 0) {
                if(City == "ЗАГЛУШКА") {

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
    }
}
