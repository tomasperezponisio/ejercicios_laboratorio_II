using System;
using LogicaValidador;

namespace Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            int minimo = 0;
            int maximo = 0;
            int sumaNumeros = 0; ;
            float promedio = 0.0f;
            bool resultado = false;
            int minRango = -100;
            int maxRango = 100;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
                while (!resultado || !Validador.Validar(numero, minRango, maxRango))
                {
                    Console.WriteLine("**ERROR** Ingrese un numero valido:");
                    numeroTexto = Console.ReadLine();
                    resultado = int.TryParse(numeroTexto, out numero);
                }                

                if (i == 0) // cargo en los minimo y maximo el primer numero ingresado
                {
                    minimo = numero;
                    maximo = numero;
                }
                if (numero < minimo) // voy guardando el minimo
                {
                    minimo = numero;
                }
                if (numero > maximo) // voy guardando el maximo
                {
                    maximo = numero;
                }
                sumaNumeros += numero; // voy acumulando para sacar el promedio

            }
            promedio = (float)sumaNumeros / 10; // saco promedio

            Console.WriteLine($"EL numero mas bajo fue el {minimo}, el mas alto fue el {maximo} y el promedio es {promedio}");

        }
    }
}
