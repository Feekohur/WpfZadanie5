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
    /// Logika interakcji dla klasy AddandEditWindow.xaml
    /// </summary>
    public partial class AddandEditWindow : Window
    {
        public string tytul { get; set; }
        public DateTime? data { get; set; }
        public string opis { get; set; }
        public AddandEditWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tytul = tyt.Text;
            data = dat.SelectedDate;
            opis = opi.Text;
            DialogResult = true;
            Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tyt.Text = tytul;
            dat.SelectedDate = data;
            opi.Text = opis;
        }
    }
}
