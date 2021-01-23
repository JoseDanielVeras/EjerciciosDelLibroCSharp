using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ejercicio3_4
{
    public Ejercicio3_4()
    {
        int numero;

        Console.WriteLine("\t.:Este Programa Dice Que Dia Es Cada Nuemro:.\n");


        Console.Write("Digite un numero del 1 al 7: ");
        numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("El numero {0} es el día Domingo", numero);
                break;
            case 2:
                Console.WriteLine("El numero {0} es el día Lunes", numero);
                break;
            case 3:
                Console.WriteLine("El numero {0} es el día Martes", numero);
                break;
            case 4:
                Console.WriteLine("El numero {0} es el día Miercoles", numero);
                break;
            case 5:
                Console.WriteLine("El numero {0} es el día Jueves", numero);
                break;
            case 6:
                Console.WriteLine("El numero {0} es el día Viernes", numero);
                break;
            case 7:
                Console.WriteLine("El numero {0} es el día Sabado", numero);
                break;
            default:
                Console.WriteLine("El numero {0} no es ningún día", numero);
                break;
        }
    }
}
