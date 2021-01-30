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
    public partial class Ejercicio2 : Form
    {
        Hashtable diccionario = new Hashtable();

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            diccionario.Add("Celaje", "Cuando en el cielo se pueden observar nubes de distintas texturas, formando un horizonte colorido en la puesta o salida del sol.");
            diccionario.Add("Ful", "Faso, fallido, que posee poco valor.");
            diccionario.Add("Descambiar", "Deshacer un cambio.");
            diccionario.Add("Zaino", "Traidor, falso, poco seguro en el trato.");
            diccionario.Add("Entronque", "Relación de parentesco entre personas quienes comparten un tronco del linaje en común.");
            
            textBoxSignifica.Text = (string)diccionario[Convert.ToString(textBoxPalabra.Text)];
        }
    }
}
