using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.Capitulo7;
using Tarea3.Capitulo6;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEjercicio7_1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void ButtonEjercicio7_2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void ButtonEjercicio7_5_Click(object sender, EventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        private void buttonEjercicio6_1_Click(object sender, EventArgs e)
        {
            Ejercicio6_1 ejercicio6_1 = new Ejercicio6_1();
            ejercicio6_1.Show();
        }

        private void buttonEjercicio6_2_Click(object sender, EventArgs e)
        {
            Ejercicio6_2 ejercicio6_2 = new Ejercicio6_2();
            ejercicio6_2.Show();
        }

        private void buttonEjercicio6_3_Click(object sender, EventArgs e)
        {
            Ejercicio6_3 ejercicio6_3 = new Ejercicio6_3();
            ejercicio6_3.Show();
        }

        private void buttonEjercicio6_4_Click(object sender, EventArgs e)
        {
            Ejercicio6_4 ejercicio6_4 = new Ejercicio6_4();
            ejercicio6_4.Show();
        }

        private void buttonEjercicio6_5_Click(object sender, EventArgs e)
        {
            Ejercicio6_5 ejercicio6_5 = new Ejercicio6_5();
            ejercicio6_5.Show();
        }
    }
}
