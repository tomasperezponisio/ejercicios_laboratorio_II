using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta utn = new Cuenta("UTN", 100);
            utn.Ingresar(500);
            Console.WriteLine(utn.Mostrar());
            utn.Ingresar(-250);
            Console.WriteLine(utn.Mostrar());
            utn.Retirar(125);
            Console.WriteLine(utn.Mostrar());

        }
    }
}
