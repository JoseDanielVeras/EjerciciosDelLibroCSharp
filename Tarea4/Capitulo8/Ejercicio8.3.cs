using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea4.Capitulo8
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void MostrarHoraFechaButton_Click(object sender, EventArgs e)
        {
            HoraTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
            FechaTextBox.Text = DateTime.Now.ToString("yyyy/dd/MM");
        }
    }
}
