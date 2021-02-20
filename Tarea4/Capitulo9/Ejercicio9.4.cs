using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea4.Capitulo9
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        enum tiposNeumaticos { verano, invierno, deportivos, dePista, todoTerreno, antiPincho, todoTiempo, otros}

        public void Tipos()
        {
            tiposNeumaticos neumaticos = tiposNeumaticos.antiPincho;
            int opcion = Convert.ToInt32(NumeroTextBox.Text);

            switch (opcion)
            {
                case 1:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.verano);
                    break;

                case 2:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.invierno);
                    break;

                case 3:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.deportivos);
                    break;

                case 4:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.dePista);
                    break;

                case 5:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.todoTerreno);
                    break;

                case 6:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.antiPincho);
                    break;

                case 7:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.todoTiempo);
                    break;

                case 8:
                    OpcionTextBox.Text = Convert.ToString(tiposNeumaticos.otros);
                    break;

                default:
                    MessageBox.Show("Pruebe con un numero entre 1 y 8.");
                    break;
            }
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Tipos();
        }
    }
}
