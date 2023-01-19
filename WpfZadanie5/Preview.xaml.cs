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

namespace WpfZadanie5
{
    /// <summary>
    /// Logika interakcji dla klasy Preview.xaml
    /// </summary>
    public partial class Preview : Window
    {
        public string tytul { get; set; }
        public string data { get; set; }
        public string opis { get; set; }
        public Preview()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tyt.Content = tytul;
            dat.Content = data;
            opi.Content = opis;
        }
    }
}
