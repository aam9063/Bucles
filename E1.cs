/*
 Programa que lee una secuencia de números no nulos, terminada con la introducción de un 0, 
y muestra el mayor de la secuencia.
*/

using System;

public class Program
{
    public static void Main()
    {
        int numero;
        int maximo = int.MinValue;

        Console.WriteLine("Introduce una secuencia de números:");

        while (true)
        {
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero == 0)
                {
                    break; // Si se ingresa 0, terminamos el bucle
                }

                if (numero > maximo)
                {
                    maximo = numero; // Actualizamos el máximo si es necesario
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Introduce un número válido.");
            }
        }

        if (maximo != int.MinValue)
        {
            Console.WriteLine("El número más grande de la secuencia es: " + maximo);
        }
        else
        {
            Console.WriteLine("Número no válido.");
        }
    }
}
