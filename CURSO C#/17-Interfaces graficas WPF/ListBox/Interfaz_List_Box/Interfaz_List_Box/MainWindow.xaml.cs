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

namespace Interfaz_List_Box
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> ListaPob = new List<Poblaciones>();

            ListaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 23,DiferenciaTemp= 9 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Colombia", Poblacion2 = "Medellin", Temperatura1 = 14, Temperatura2 = 25, DiferenciaTemp = 9 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Buenos Aires", Poblacion2 = "Cancun", Temperatura1 = 23, Temperatura2 = 28 ,DiferenciaTemp = 5 });
            ListaPob.Add(new Poblaciones() { Poblacion1 = "Francia", Poblacion2 = "Portugal", Temperatura1 = 23, Temperatura2 = 10, DiferenciaTemp = 13 });

            ListaPoblaciones.ItemsSource = ListaPob;      // Se realiza para conectar la lista que hay en el CS con el xaml.cs
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
               (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " +
               (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
               (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento");
            }
           
        }
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
           (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " +
           (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
           (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC ");
        }
    }
    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }
        public int DiferenciaTemp { get; set; }
    }
}
