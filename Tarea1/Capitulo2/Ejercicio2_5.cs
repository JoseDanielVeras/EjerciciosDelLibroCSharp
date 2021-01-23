using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ejercicio2_5
{
    public Ejercicio2_5()
    {
        int opcion;
        double dolar;
        double euro;

        Console.WriteLine("\t.:Programa Para Cambiar Entre Dolar y Euro:.\n");

        Console.WriteLine("1) Dolar a Euro\n2) Euro a Dolar");
        Console.WriteLine("Elija una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Digite la cantidad de Dolares: ");
            dolar = Convert.ToSingle(Console.ReadLine());

            euro = dolar * 0.82;

            Console.Write("{0} dolares es igual a ", dolar);
            Console.WriteLine("{0} euros", euro);

        }
        else if (opcion == 2)
        {
            Console.Write("Digite la cantidad de Euros: ");
            euro = Convert.ToSingle(Console.ReadLine());

            dolar = euro / 0.82;

            Console.Write("{0} Euros es igual a ", euro);
            Console.WriteLine("{0} Dolares", dolar);
        }
    }
}

