﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tarea3.Capitulo6
{
    public partial class Ejercicio6_2 : Form
    {
        int Salones;
        int Cantidad;
        int Contador = 0;
        float Suma = 0.0f;
        float Promedio = 0.0f;
        int[][] Calificaciones;
        int CalificacionMenor = 100;

        public Ejercicio6_2()
        {
            InitializeComponent();
        }

        private void AnadirBotton_Click_1(object sender, EventArgs e)
        {
            Salones = Convert.ToInt32(textBoxSalones.Text);
            Calificaciones = new int[Salones][];

            for (int n = 0; n < Salones; n++)
            {
                Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite la cantidad de alumnos por salón " + (n + 1), "Cantidad de Alumnos", " ", 100, 0));
                Calificaciones[n] = new int[Cantidad];
                Contador += Cantidad;
            }
            textBoxSalones.Text = "";
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {

            for (int n = 0; n < Salones; n++)
            {
                for (int m = 0; m < Calificaciones[n].GetLength(0); m++)
                {
                    Calificaciones[n][m] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite la calificación del alumno " + (m + 1) + " del salón " + (n + 1), "Calificaciones", " ", 100, 0));
                    Suma += Calificaciones[n][m];

                    if (Calificaciones[n][m] < CalificacionMenor)
                        CalificacionMenor = Calificaciones[n][m];
                }
            }

            Promedio = Suma / Contador;
            textBoxPromedio.Text = Promedio.ToString();
            CalifMenorTextBox.Text = CalificacionMenor.ToString();

            for (int n = 0; n < Salones; n++)
            {
                CalificacionesListBox.Items.Add("Salón " + (n + 1));

                for (int m = 0; m < Calificaciones[n].GetLength(0); m++)
                {
                    CalificacionesListBox.Items.Add("El alumno " + (m + 1) + " tiene " + Calificaciones[n][m]);
                }
            }
        }
    }
}
