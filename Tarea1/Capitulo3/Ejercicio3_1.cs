using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ejercicio3_1
{
    public Ejercicio3_1()
    {
        int numero;

        Console.WriteLine("\t.:Este Programa Dice Si Un Numero Es Par O Impar:.\n");

        Console.Write("Digite un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine("El numero {0} es par", numero);
        else
            Console.WriteLine("El numero {0} es impar", numero);
    }
}

