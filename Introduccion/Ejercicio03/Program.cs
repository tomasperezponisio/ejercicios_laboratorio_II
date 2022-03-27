using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string salir = "no";
            string numeroTexto;
            bool resultado;
            //int contadorPrimos;
            
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
                while (!resultado)
                {
                    Console.WriteLine("**ERROR** Ingrese un numero valido:");
                    numeroTexto = Console.ReadLine();
                    resultado = int.TryParse(numeroTexto, out numero);
                }
                Console.WriteLine($"Numeros primos previos a {numero}: ");
                for (int i = 0; i < numero; i++)
                {
                    if (esPrimo(i))
                    {
                        Console.WriteLine($"{i}");
                    }
                }               

                Console.WriteLine("Desea ingresar otro numero? (si / no):");
                salir = Console.ReadLine();

            } while (salir == "si");

        }
        public static bool esPrimo(int numero)
        {
            bool todoOk = false;
            int esDivisible = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    esDivisible++;
                }
            }
            if (esDivisible == 2)
            {
                todoOk = true;
            }
            return todoOk;
        }
    }
}
