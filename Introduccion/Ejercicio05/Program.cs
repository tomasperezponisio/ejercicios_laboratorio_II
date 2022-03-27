using System;

namespace Ejercicio05
{
    internal class Program
    {
        // Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en dos grupos de números,
        // cuyas sumas son iguales.
        // El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas
        // sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en
        // los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.
        // Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que
        // el usuario ingrese por consola.

        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            bool resultado = false;

            Console.WriteLine("Ingrese un numero:");
            numeroTexto = Console.ReadLine();
            resultado = int.TryParse(numeroTexto, out numero);
            while (!resultado)
            {
                Console.WriteLine("**ERROR** Ingrese un numero valido:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
            }

            for (int i = 1; i < numero; i++)
            {
                if (esCentrico(i))
                {
                    Console.WriteLine($"El numero {i} es CENTRICO");
                }                
            }

        }
        public static bool esCentrico(int numero)
        {
            bool todoOk = false;
            int sumaPrevia = 0;
            int sumaPosterior = 0;
            for (int i = 1; i < numero; i++)
            {
                sumaPrevia += i;
            }
            while (sumaPosterior < sumaPrevia)
            {
                numero++;
                sumaPosterior += numero;
            }
            if (sumaPosterior == sumaPrevia)
            {
                todoOk = true;
            }
            return todoOk;
        }
    }
}
