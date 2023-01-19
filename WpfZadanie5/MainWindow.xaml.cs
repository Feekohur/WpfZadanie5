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

namespace WpfZadanie5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Film film;
        Preview preview;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddandEditWindow addandeditwindow = new AddandEditWindow();
            if(addandeditwindow.ShowDialog() == true)
            {
                film = new Film(addandeditwindow.tytul, (DateTime)addandeditwindow.data, addandeditwindow.opis);
                listbox.Items.Add(film);
                listbox.Items.Refresh();
            }

        }

        private void Preview_Click(object sender, RoutedEventArgs e)
        {
            
            if(preview!= null)
            {
                MessageBox.Show("Nie można mieć więcej niż jeden podgląd!", "Za dużo podglądów", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                preview = new Preview();
                var pom = listbox.SelectedItem as Film;
                preview.tytul = pom.tytul;
                preview.data = pom.data.ToString();
                preview.opis = pom.opis;
                preview.Show();
            }
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy chcesz usunąć dokładnie ten element?","Usuwanie", MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                listbox.Items.Remove(listbox.SelectedItem);
                listbox.Items.Refresh();
            }
                
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listbox.SelectedIndex >=0 && listbox.SelectedIndex <= listbox.Items.Count - 1)
            {
                usun.IsEnabled = true;
                edytuj.IsEnabled = true;
                podglad.IsEnabled = true;
            }
            else
            {
                usun.IsEnabled = false;
                edytuj.IsEnabled = false;
                podglad.IsEnabled = false;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            AddandEditWindow addandeditwindow = new AddandEditWindow();
            var pom = listbox.SelectedItem as Film;
            addandeditwindow.tytul = pom.tytul;
            addandeditwindow.data = pom.data;
            addandeditwindow.opis = pom.opis;
            if (addandeditwindow.ShowDialog() == true)
            {
                pom.tytul = addandeditwindow.tytul;
                pom.data = (DateTime)addandeditwindow.data;
                pom.opis = addandeditwindow.opis;
                listbox.Items.Refresh();
            }
        }
    }
}
