using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea3.Capitulo7
{
    public partial class Ejercicio5 : Form
    {

        Hashtable Agenda = new Hashtable();

        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Agenda.Add(Convert.ToString(textBoxNombre.Text),Convert.ToString(textBoxTelefono.Text));
            textBoxNombre.Text = textBoxTelefono.Text = "";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = (string)Agenda[Convert.ToString(textBoxBuscarNombre.Text)];
        }

        private void buttonBorar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBoxBuscarNombre.Text = "";
        }
    }
}
