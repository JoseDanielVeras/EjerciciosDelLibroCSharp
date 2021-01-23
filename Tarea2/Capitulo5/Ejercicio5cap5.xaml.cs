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
    /// Interaction logic for Ejercicio5cap5.xaml
    /// </summary>
    public partial class Ejercicio5cap5 : Window
    {
        public Ejercicio5cap5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numero = Convert.ToInt32(TextBoxNumero.Text);
            Cadena(numero);
        }

        void Cadena(int numero)
        {
            switch(numero)
            {
                case 1:
                    TextBoxResultado.Text = "Uno";
                    break;

                case 2:
                    TextBoxResultado.Text = "Dos";
                    break;

                case 3:
                    TextBoxResultado.Text = "Tres";
                    break;

                case 4:
                    TextBoxResultado.Text = "Cuatro";
                    break;

                case 5:
                    TextBoxResultado.Text = "Cinco";
                    break;

                case 6:
                    TextBoxResultado.Text = "Seis";
                    break;

                case 7:
                    TextBoxResultado.Text = "Siete";
                    break;

                case 8:
                    TextBoxResultado.Text = "Ocho";
                    break;

                case 9:
                    TextBoxResultado.Text = "Nueve";
                    break;

                case 10:
                    TextBoxResultado.Text = "Dies";
                    break;

                default:
                    TextBoxResultado.Text = "Numero no habilitad";
                    break;
            }
        }
    }
}
