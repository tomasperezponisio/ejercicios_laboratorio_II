using System;
using LogicaTablas;

namespace tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            bool numeroValidar;

            Console.Write("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            numeroValidar = int.TryParse(numeroString, out numero);
            while (!numeroValidar)
            {
                Console.Write("**ERROR** Ingrese un numero valido: ");
                numeroString = Console.ReadLine();
                numeroValidar = int.TryParse(numeroString, out numero);
            }

            Console.WriteLine(Tablas.Calcular(numero));


        }
    }
}
