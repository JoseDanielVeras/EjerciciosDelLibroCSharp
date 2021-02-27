using System;

public class Ejercicio12_1
{
    public Ejercicio12_1()
    {
        init_Class();
    }

    public void init_Class()
    {
        int numero, factorial;

        Console.Write("Ingrese el numero para factorial: ");
        numero = Convert.ToInt32(Console.ReadLine());

        CalcFactorial(
            numero, factorial);

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    public int CalcFactorial(int numero, ref int producto)
    {
        producto = 1;

        for (int i = numero; i >= 1; i--)
        {
            producto *= i;
        }
    }
}