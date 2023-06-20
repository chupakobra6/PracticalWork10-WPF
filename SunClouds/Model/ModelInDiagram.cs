using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.Model
{
    internal class ModelInDiagram : BindingHelper
    {
        private double x;
        private double y;
        public double X
        {
            get { return x; }
            set { x = value; OnPropertyChanged(); }
        }
        public double Y
        {
            get { return x; }
            set { x = value; OnPropertyChanged(); }
        }

    }
}

