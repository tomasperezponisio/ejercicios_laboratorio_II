using System;
using LogicaConversor;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal;
            string numeroTexto;
            bool numeroValidar;

            int numeroBinario;
            string numeroBinarioTexto;
            bool numeroBinarioValidar;

            Console.Write("Ingrese un numero decimal: ");
            numeroTexto = Console.ReadLine();
            numeroValidar = int.TryParse(numeroTexto, out numeroDecimal);
            while (!numeroValidar)
            {
                Console.Write("**ERROR** Ingrese un numero valido: ");
                numeroTexto = Console.ReadLine();
                numeroValidar = int.TryParse(numeroTexto, out numeroDecimal);
            }
            string binarioInvertido = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.WriteLine($"El numero {numeroDecimal} en binario es {binarioInvertido}");

            Console.Write("\nIngrese un numero binario: ");
            numeroBinarioTexto = Console.ReadLine();
            numeroBinarioValidar = int.TryParse(numeroBinarioTexto, out numeroBinario);
            while (!numeroBinarioValidar)
            {
                Console.Write("**ERROR** Ingrese un numero valido: ");
                numeroBinarioTexto = Console.ReadLine();
                numeroBinarioValidar = int.TryParse(numeroBinarioTexto, out numeroBinario);
            }
            Console.WriteLine($"El numero {numeroBinario} en decimal es {Conversor.ConvertirBinarioADecimal(numeroBinario)}");
        }
    }
}
