using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Tomas", "24/2/1985", "31443243");
            Persona persona2 = new Persona("Julia", "5/7/1987", "33103475");
            Persona persona3 = new Persona("Felipe", "13/3/2005", "34123123");

            Persona persona4 = new Persona();

                     
            Console.WriteLine($"{persona1.Mostrar()} y {persona1.EsMayorDeEdad()}");
            Console.WriteLine($"{persona2.Mostrar()} y {persona2.EsMayorDeEdad()}");
            Console.WriteLine($"{persona3.Mostrar()} y {persona3.EsMayorDeEdad()}");

            // no se como manejar si el formato no es valido <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            Console.WriteLine($"{persona4.Mostrar()} y {persona4.EsMayorDeEdad()}");


        }
    }
}
