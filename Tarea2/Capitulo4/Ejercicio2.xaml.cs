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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularBotton_Click(object sender, RoutedEventArgs e)
        {
            int numero = Convert.ToInt32(TextBoxNumero.Text);
            int potencia = Convert.ToInt32(TextBoxPotencia.Text);
            int res;

            for(res = 1; potencia >= 1; potencia--)
            {
                res *= numero;
            }

            ResultadoTextBox.Text = Convert.ToString( res );
        }
    }
}
