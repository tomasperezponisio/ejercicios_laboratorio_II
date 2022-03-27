using System;

namespace Ejercicio04
{
    internal class Program
    {
        // Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo)
        // que son divisores del número.
        // El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        // Escribir una aplicación que encuentre los 4 primeros números perfectos.

        static void Main(string[] args)
        {
            int numero = 1;
            int contadorPerfectos = 0;            

            while (contadorPerfectos < 4)
            {
                if (esPerfecto(numero))
                {
                    Console.WriteLine($"El numero {numero} es perfecto");
                    contadorPerfectos++;
                }
                numero++;
            }            

        }
        public static bool esPerfecto(int numero)
        {
            bool resultado = false;
            int sumaDivisores = 0;

            for (int i = 1; i < numero; i++)
            {
                if (esDivisible(numero, i))
                {
                    sumaDivisores += i;
                }
            }
            if (sumaDivisores == numero)
            {
                resultado = true;
            }
            return resultado;
        }
        public static bool esDivisible(int numero, int divisor)
        {
            bool resultado = false;
            if (numero % divisor == 0)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
