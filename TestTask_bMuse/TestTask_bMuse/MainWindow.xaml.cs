using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Data.Entity;
using Newtonsoft.Json;

namespace TestTask_bMuse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Context();
        }

        public void OutputTable()
        {
            try
            {
                string jsonWeather = System.IO.File.ReadAllText(@"C:\Users\Алексей\Desktop\TestTask_bMuse\TestTask_bMuse\jsonWeather.txt", Encoding.Default);

                var objectWeather = JsonConvert.DeserializeObject<Weather>(jsonWeather);
                Database.SetInitializer<Context>(null);
                // add to the database
                db.WeatherByMonth.Add(objectWeather);
                // get objects from the bd and output to the table
                DataGridWeather.ItemsSource = db.WeatherByMonth.Local.ToBindingList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonGetInfoClick(object sender, RoutedEventArgs e)
        {
            OutputTable();
        }

        private void RowClicked(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DataGridWeather.ItemsSource = db.WeatherByDate.Local.ToBindingList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void MenuExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuHelpClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("To open the collection, double-click on the cell");
        }
    }
}
