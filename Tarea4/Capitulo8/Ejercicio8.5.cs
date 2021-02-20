using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea4.Capitulo8
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            string cadena1 = CadenaUnoTextBox.Text;
            string cadena2 = CadenaDosTextBox.Text;

            int comparar = String.Compare(cadena1, cadena2);

            if(comparar > 0)
            {
                OrdenarlistBox.Items.Clear();
                OrdenarlistBox.Items.Add("Ordenado:");
                OrdenarlistBox.Items.Add(cadena2);
                OrdenarlistBox.Items.Add(cadena1);
            }
            else
            {
                OrdenarlistBox.Items.Clear();
                OrdenarlistBox.Items.Add("Ordenado:");
                OrdenarlistBox.Items.Add(cadena1);
                OrdenarlistBox.Items.Add(cadena2);
            }

        }
    }
}
