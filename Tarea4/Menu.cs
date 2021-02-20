using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea4.Capitulo8;
using Tarea4.Capitulo9;

namespace Tarea4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ejercicio3Button_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void Ejercicio5Button_Click(object sender, EventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        private void Ejercicio1Button_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void Ejercicio9_4Button_Click(object sender, EventArgs e)
        {
            Ejercicio9 ejercicio9 = new Ejercicio9();
            ejercicio9.Show();
        }
    }
}
