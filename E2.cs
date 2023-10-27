/*
Programa que obtenga el cociente y el resto de dividir dos números enteros positivos utilizando restas restas. Por ejemplo, para calcular n / 2 haga n -= 2 mientras n >= 2 y 
cuente el número de veces que ha restado.
*/

using System;

public class Program
{
    public static void Main()
    {

        Console.Write("Ingrese el dividendo (n): ");
        int dividendo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el divisor (d): ");
        int divisor = int.Parse(Console.ReadLine());

        if (dividendo < 0 || divisor <= 0)
        {
            Console.WriteLine("Por favor, ingrese números enteros positivos.");
        }
        else
        {
            int cociente = 0;
            int resto = dividendo;
            int contadorRestas = 0;

            while (resto >= divisor)
            {
                resto -= divisor;
                cociente++;
                contadorRestas++;
            }

            Console.WriteLine("Cociente: " + cociente);
            Console.WriteLine("Resto: " + resto);
            Console.WriteLine("Número de restas realizadas: " + contadorRestas);
        }
    }
}
