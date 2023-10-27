/*
Simulación de una calculadora 
Realiza un programa que sea capaz de sumar, restar, multiplicar y dividir. 
El programa presentará un menú con las cuatro operaciones que puede realizar. Saldrá del programa con la opción SALIR
*/

using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("MENÚ");
            Console.WriteLine("------");
            Console.WriteLine("1. SUMAR");
            Console.WriteLine("2. RESTAR");
            Console.WriteLine("3. MULTIPLICAR");
            Console.WriteLine("4. DIVIDIR");
            Console.WriteLine("  ");
            Console.WriteLine("0. SALIR");

            Console.Write("Seleccione una opción (1-0): ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Bye!");
                break;
            }

            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                continue;
            }

            Console.Write("Introduzca el operador 1: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Introduzca el operador 2: ");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    break;
            }
        }
    }
}
