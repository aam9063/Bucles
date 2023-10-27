/*
Pide un número, por ejemplo, el 4, y saca en pantalla 1223334444. 
Nota: Deber usar bucles for para hacerlo. 
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
        }

        Console.WriteLine();
    }
}
