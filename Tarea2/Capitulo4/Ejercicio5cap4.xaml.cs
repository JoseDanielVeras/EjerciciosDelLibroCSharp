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
    /// Interaction logic for Ejercicio5cap4.xaml
    /// </summary>
    public partial class Ejercicio5cap4 : Window
    {

        float promedio = 0;
        int mayor = -200;
        int menor = 200;
        int contador = 1;

        public Ejercicio5cap4()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);
            int edad = Convert.ToInt32(EdadTextBox.Text);

            promedio += Convert.ToSingle(EdadTextBox.Text);

            if (Convert.ToInt32(EdadTextBox.Text) < menor)
                menor = Convert.ToInt32(EdadTextBox.Text);
            
            if (Convert.ToInt32(EdadTextBox.Text) > mayor)
                mayor = Convert.ToInt32(EdadTextBox.Text);
            EdadTextBox.Text = "";
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {   
            EdadMayorTextBox.Text = Convert.ToString(mayor);
            EdadMenorTextBox.Text = Convert.ToString(menor);
            PromedioTextBox.Text = Convert.ToString(promedio / Convert.ToSingle(CantidadTextBox.Text));
        }

        private void BorrarButton_Click(object sender, RoutedEventArgs e)
        {
            CantidadTextBox.Text = "";
            EdadTextBox.Text = "";
            PromedioTextBox.Text = "";
            EdadMayorTextBox.Text = "";
            EdadMenorTextBox.Text = "";
        }
    }
}
