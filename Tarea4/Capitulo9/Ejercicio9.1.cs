using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea4.Capitulo9
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            public string nombre;
            public double precio;

            public Productos(string Nombre, double Precio)
            {
                nombre = Nombre;
                precio = Precio;
            }
        }

        Productos[] productos = new Productos[10];
        int acumulador = 0;

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            productos[acumulador].precio = Convert.ToDouble(PrecioTextBox.Text);
            productos[acumulador].nombre = NombreTextBox.Text;
            acumulador++;
        }
    }
}
