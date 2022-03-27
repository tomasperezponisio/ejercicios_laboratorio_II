using System;
using LogicaValidador;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            bool resultadoNumero = false;
            char respuesta;
            string respuestaTexto;
            bool resultadoChar = false;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultadoNumero = int.TryParse(numeroTexto, out numero);
                while (!resultadoNumero)
                {
                    Console.WriteLine("**ERROR** Ingrese un numero valido:");
                    numeroTexto = Console.ReadLine();
                    resultadoNumero = int.TryParse(numeroTexto, out numero);
                }
                Console.WriteLine("Desea continuar? (S/N)");
                respuestaTexto = Console.ReadLine();
                respuesta = char.Parse(respuestaTexto); // falta validar que haya ingresado un char
            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
