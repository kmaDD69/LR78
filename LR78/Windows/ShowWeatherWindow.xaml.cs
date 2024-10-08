using LR78.CustomControls;
using LR78.DataModel;
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
using System.Windows.Shapes;

namespace LR78.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherWindow.xaml
    /// </summary>
    public partial class ShowWeatherWindow : Window
    {
        public ShowWeatherWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() => new ModelEF().Prognosis.ToList().ForEach(item => wrapPanelWeather.Children.Add(new PrognosisWeather(item)));

        private void buttonBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}
