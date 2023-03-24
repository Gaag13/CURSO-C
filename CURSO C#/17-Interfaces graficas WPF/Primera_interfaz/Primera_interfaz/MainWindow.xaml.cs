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

namespace Primera_interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region BOTON PROPIEDADES
            //Grid miGrid = new Grid();

            //this.Content = miGrid;

            //Button miBoton = new Button();
            //miBoton.Width = 150;
            //miBoton.Height = 75;
            //miBoton.Background = Brushes.Pink;
            

            //WrapPanel miWrapPanel = new WrapPanel();

            //TextBlock txt1= new TextBlock();
            //txt1.Text = "Click";
            //txt1.Foreground= Brushes.Red;
            ////txt1.Background = Brushes.White;
            //miWrapPanel.Children.Add(txt1);

            //TextBlock txt2 = new TextBlock();
            //txt2.Text = "Enviar";
            //miWrapPanel.Children.Add(txt2);

            //TextBlock txt3 = new TextBlock();
            //txt3.Text = "Borrar";
            //miWrapPanel.Children.Add(txt3);

            //miBoton.Content = miWrapPanel;

            //miGrid.Children.Add(miBoton);
            #endregion
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado click al boton"); 
        }

       /* private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel");
        }*/

        // Evento tipo TUNELL
        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel");
        }
    }
}
