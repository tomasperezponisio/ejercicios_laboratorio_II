using System;

namespace Ejercicio_08
{
    internal class Program
    {
        // Escribir un programa que imprima por consola un triángulo como el siguiente:
        // *
        // ***
        // *****
        // *******
        // *********
        // El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo
        // Para el ejemplo anterior, la altura ingresada fue de 5.
        static void Main(string[] args)
        {
            int altura;
            string alturaString;
            bool alturaValidar;
            
            Console.Write("Ingrese la altura de la piramide: ");
            alturaString = Console.ReadLine();
            alturaValidar = int.TryParse(alturaString, out altura);
            while (!alturaValidar || altura < 1)
            {
                Console.WriteLine("**ERROR** Ingrese un valor de hora trabajada valido:");
                alturaString = Console.ReadLine();
                alturaValidar = int.TryParse(alturaString, out altura);
            }

            for (int i = 0; i < altura; i++)
            {
                for (int j = 1; j <= i+(i+1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
