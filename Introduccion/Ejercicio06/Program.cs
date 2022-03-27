using System;

namespace Ejercicio06
{
    internal class Program
    {
        // Escribir un programa que determine si un año es bisiesto.
        // Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
        // también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        // Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        static void Main(string[] args)
        {
            int anioMin;
            string anioMinString;
            bool anioMinValidar;
            int anioMax;
            string anioMaxString;
            bool anioMaxValidar;

            Console.Write("Ingrese un año de inicio: ");
            anioMinString = Console.ReadLine();
            anioMinValidar = int.TryParse(anioMinString, out anioMin);
            while (!anioMinValidar || anioMin < 1)
            {
                Console.WriteLine("**ERROR** Ingrese un año valido:");
                anioMinString = Console.ReadLine();
                anioMinValidar = int.TryParse(anioMinString, out anioMin);
            }

            Console.Write("Ingrese un año de fin: ");
            anioMaxString = Console.ReadLine();
            anioMaxValidar = int.TryParse(anioMaxString, out anioMax);
            while (!anioMaxValidar || anioMax < 1)
            {
                Console.WriteLine("**ERROR** Ingrese un año valido:");
                anioMaxString = Console.ReadLine();
                anioMaxValidar = int.TryParse(anioMaxString, out anioMax);
            }

            for (int i = anioMin; i <= anioMax; i++)
            {
                if (esBisiesto(i))
                {
                    Console.WriteLine($"el año {i} es bisiesto");
                }                
            }         
        }
        public static bool esBisiesto(int numero)
        {
            bool todoOk = false;

            if (numero % 4 == 0)
            {
                if (numero % 100 != 0 || numero % 400 == 0)
                {
                    todoOk = true;
                    //Console.WriteLine($"EL numero {numero} es bisiesto");
                }
            }
            return todoOk;
        }
    }
}
