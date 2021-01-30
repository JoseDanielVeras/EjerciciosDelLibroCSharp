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
    public partial class Ejercicio1 : Form
    {
        ArrayList Calificaciones = new ArrayList();

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {  
           if(Convert.ToInt32(textBoxCalificacion.Text) > 10 || Convert.ToInt32(textBoxCalificacion.Text) < 0)
            {
                MessageBox.Show("Solo se pueden ingresar calificaicones del 0 al 10");
                return;
            }
            
            Calificaciones.Add(Convert.ToInt32(textBoxCalificacion.Text));
            textBoxCalificacion.Text = "";
        }

        float Promedio(ArrayList arrayList)
        {
            float suma = 0;
            for(int i = 0; i < arrayList.Count; i++)
            {
                suma += Convert.ToInt32(arrayList[i]);
            }
            
            return suma / arrayList.Count;
        }

        float Mayor(ArrayList arrayList)
        {
            int mayor = -1;
            for(int i = 0; i < arrayList.Count; i++)
            {
                if (Convert.ToInt32(arrayList[i]) > mayor)
                    mayor = Convert.ToInt32(arrayList[i]);
            }
            return mayor;
        }

        float Menor(ArrayList arrayList)
        {
            int menor = 10;
            for(int i = 0; i < arrayList.Count; i++)
            {
                if (Convert.ToInt32(arrayList[i]) < menor)
                    menor = Convert.ToInt32(arrayList[i]);
            }
            return menor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPromedio.Text = Convert.ToString(Promedio(Calificaciones));

            textBoxCaliMaxima.Text = Convert.ToString(Mayor(Calificaciones));

            textBoxCaliMinima.Text = Convert.ToString(Menor(Calificaciones));
        }
    }
}
