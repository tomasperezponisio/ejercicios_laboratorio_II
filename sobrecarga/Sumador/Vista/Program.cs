using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);

            Console.WriteLine($"La suma de 2 long {sumador.Sumar(45, 2)}");
            Console.WriteLine($"La suma de 2 string {sumador.Sumar("Hola ", "che")}");

            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumador + sumadorB);
            Console.WriteLine(sumador | sumadorB);
            Console.WriteLine(sumador | sumadorC);
        }
    }
}
