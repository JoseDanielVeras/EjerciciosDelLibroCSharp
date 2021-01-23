using System;


class Ejercicio2_1
{
    public Ejercicio2_1()
    {
        int lados;
        float tamanio;
        float perimetro;

        Console.WriteLine("\t.:Programa Para Calcular El Eerimero De Un Poligo Regular:.");
        do
        {
            Console.WriteLine("\nDigita la cantidad de lados: ");
            lados = Convert.ToInt32(Console.ReadLine());
        } while (lados < 3);

        do
        {
            Console.WriteLine("Digite el tamanio de los lados: ");
            tamanio = Convert.ToSingle(Console.ReadLine());
        } while (tamanio < 1);

        Console.Write("El perimetro del poligono es: {0}", perimetro = tamanio * lados);
    }
}
