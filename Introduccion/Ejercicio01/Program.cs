using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int min = 0;
            int max = 0;
            int suma = 0;
            decimal promedio = 0;
            string numeroTexto;
            bool resultado;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
                while (!resultado)
                {
                    Console.WriteLine("**ERROR** Ingrese un numero:");
                    numeroTexto = Console.ReadLine();
                    resultado = int.TryParse(numeroTexto, out numero);
                }
                if (i == 0)
                {
                    min = numero;
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }
                if (numero > max)
                {
                    max = numero;
                }
                suma += numero;
            }

            promedio = (decimal)suma / 5;

            Console.WriteLine($"El numero mas chico es: {min}, el mas grande es {max} y el promedio es {promedio}");
        }
    }
}
