using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OtraClase objeto;
            try
            {
                objeto = new OtraClase();
                objeto.MiMetodoInstancia();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);

                Exception exInner = ex.InnerException;

                while (exInner != null)
                {
                    Console.WriteLine(exInner.Message);
                    exInner = exInner.InnerException;
                }
            }




        }
    }
}
