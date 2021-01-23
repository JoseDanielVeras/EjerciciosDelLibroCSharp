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

namespace EjerciciosTarea2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio1Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void Ejercicio2Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void Ejercicio4Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }

        private void Ejercicio5Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap4 ejercicio5Cap4 = new Ejercicio5cap4();
            ejercicio5Cap4.Show();
        }

        private void Ejercicio5Button2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5cap5 ejercicio5Cap5 = new Ejercicio5cap5();
            ejercicio5Cap5.Show();
        }
    }
}
