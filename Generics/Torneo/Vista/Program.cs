using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFubtol = new Torneo<EquipoFutbol>("Torneo de Futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de Basquet");

            EquipoFutbol boca = new EquipoFutbol("boca", DateTime.Now);
            EquipoFutbol racing = new EquipoFutbol("racing", DateTime.Now);
            EquipoFutbol huracan = new EquipoFutbol("huracan", DateTime.Now);

            EquipoBasquet atenas = new EquipoBasquet("atenas", DateTime.Now);
            EquipoBasquet estudiantes = new EquipoBasquet("estudiantes", DateTime.Now);
            EquipoBasquet quilmes = new EquipoBasquet("quilmes", DateTime.Now);

            torneoFubtol += boca;
            torneoFubtol += racing;
            torneoFubtol += huracan;

            torneoBasquet += atenas;
            torneoBasquet += estudiantes;
            torneoBasquet += quilmes;

            Console.WriteLine(torneoFubtol.Mostrar());
            Console.WriteLine(torneoFubtol.JugarPartido);
            Console.WriteLine(torneoFubtol.JugarPartido);
            Console.WriteLine(torneoFubtol.JugarPartido);
            Console.WriteLine("\n");

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
