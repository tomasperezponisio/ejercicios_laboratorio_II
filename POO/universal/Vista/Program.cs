using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Tomas", "Perez", "001");
            Estudiante e2 = new Estudiante("Profe", "Renzo", "002");
            Estudiante e3 = new Estudiante("Profe", "Pablo", "003");

            e1.SetNotaPrimerParcial(9);
            e2.SetNotaPrimerParcial(4);
            e3.SetNotaPrimerParcial(2);

            e1.SetNotaSegundoParcial(8);
            e2.SetNotaSegundoParcial(5);
            e3.SetNotaSegundoParcial(1);

            Console.WriteLine($"{e1.Mostrar()}\n");
            Console.WriteLine($"{e2.Mostrar()}\n");
            Console.WriteLine($"{e3.Mostrar()}\n");
        }
    }
}
