using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjerciciosTarea2
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxTabla.Items.Clear();
            int numero = Convert.ToInt32(TextBoxButton.Text);
            int resultado;

            for(int i = 1; i <= 10; i++)
            {
               resultado = numero * i;
               ListBoxTabla.Items.Add(i + " * " + numero + " = " + resultado);
            }

        }
    }
}
