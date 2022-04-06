using System;
using System.Text;
using Geometria;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(1, 1);
            Punto vertice3 = new Punto(7, 5);
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);
            Console.WriteLine($"Rectangulo creado:");
            Console.WriteLine($"vertice 1: ({vertice1.GetX()}, {vertice1.GetY()}), vertice 3: ({vertice3.GetX()}, {vertice3.GetY()})");
            Console.WriteLine($"{MostrarRectangulo(rectangulo)}");

        }

        //Mostrar
        public static string MostrarRectangulo(Rectangulo r)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append($"Area: {r.Area()}; Perimetro: {r.Perimetro()}");
            return mensaje.ToString();
        }    
    }
}
