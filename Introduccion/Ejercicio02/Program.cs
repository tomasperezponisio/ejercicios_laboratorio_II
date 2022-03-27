using System;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            double cuadrado = 0;
            double cubo = 0;
            string numeroTexto;
            bool resultado;

            Console.WriteLine("Ingrese un numero:");
            numeroTexto = Console.ReadLine();
            resultado = int.TryParse(numeroTexto, out numero);
            while (!resultado || numero < 0)
            {
                Console.WriteLine("**ERROR** Ingrese un numero valido:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
            }

            cuadrado = Math.Pow((double)numero, 2);
            cubo = Math.Pow((double)numero, 3);

            Console.WriteLine($"El numero es: {numero}, el cuadrado es {cuadrado} y el cubo es {cubo}");
        }
    }
}
