using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ejercicio2_3
{
    public Ejercicio2_3()
    {
        float grados;
        double radianes;

        Console.WriteLine(".:Programa Para Convertir De Grados a Radianes:.\n");

        Console.Write("Digite la cantidad de grados que desea convertir: ");
        grados = Convert.ToSingle(Console.ReadLine());

        radianes = grados * (System.Math.PI / 180);

        Console.Write("{0} grados ", grados);
        Console.WriteLine("Es igual a {0} radianes", radianes);
    }
}


