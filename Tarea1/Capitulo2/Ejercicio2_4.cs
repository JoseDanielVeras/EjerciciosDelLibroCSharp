using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ejercicio2_4
{
    public Ejercicio2_4()
    {
        float Centigrados;
        float fahrenheit;

        Console.WriteLine("\t.:Programa Para Convertir De Grados Centigrados a Fahrenheit:.\n");

        Console.Write("Digite los grados Centigrados: ");
        Centigrados = Convert.ToSingle(Console.ReadLine());

        fahrenheit = ((Centigrados * 9) / 5) + 32;

        Console.Write("{0} grados Celsius es igual a ", Centigrados);
        Console.WriteLine("{0} grados Fahrenheit", fahrenheit);
    }
}

