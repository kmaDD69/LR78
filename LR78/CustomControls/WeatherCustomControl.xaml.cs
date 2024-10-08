using LR78.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR78.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для WeatherCustomControl.xaml
    /// </summary>
    public partial class WeatherCustomControl : UserControl
    {
        private ComplexWeatherInfo _weather;

        public WeatherCustomControl()
        {
            InitializeComponent();
        }

        public WeatherCustomControl(ComplexWeatherInfo complex)
        {
            InitializeComponent();
            Fill(complex);
        }

        public void Fill(ComplexWeatherInfo complex)
        {
            _weather = complex ?? throw new ArgumentNullException(nameof(_weather));
            label_Humidity.Content = _weather.Humidity;
            label_Temperature.Content = _weather.Temperature;
            label_Time.Content = _weather.Time;
            label_Type.Content = _weather.Weather.Name;
        }
    }
}
