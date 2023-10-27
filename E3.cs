/*
Programa que determina si dos números enteros positivos son amigos 
Dos números son amigos si la suma de los divisores del primer número excepto él mismo, es igual al segundo numero, y viceversa.
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Comprobación de números amigos");

        Console.Write("Introduzca el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Introduzca el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int sumaDivisoresNum1 = 0;
        int sumaDivisoresNum2 = 0;

        for (int i = 1; i < num1; i++)
        {
            if (num1 % i == 0)
            {
                sumaDivisoresNum1 += i;
            }
        }

        for (int i = 1; i < num2; i++)
        {
            if (num2 % i == 0)
            {
                sumaDivisoresNum2 += i;
            }
        }

        if (sumaDivisoresNum1 == num2 && sumaDivisoresNum2 == num1)
        {
            Console.WriteLine($"{num1} y {num2} son números amigos.");
        }
        else
        {
            Console.WriteLine($"{num1} y {num2} no son números amigos.");
        }
    }
}
