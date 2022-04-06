using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor[] conductores = new Conductor[3];
            for (int i = 0; i < conductores.Length; i++)
            {
                conductores[i] = new Conductor();
            }

            string auxNombre;
            //int auxDia;
            //string auxDiaString;
            int auxKms;
            string auxKmsString;
            int maxKms = 0;
            string maxKmsConductor = "";
            for (int i = 0; i < conductores.Length; i++)
            {
                Console.Write("Ingrese el nombre del conductor: ");
                auxNombre = Console.ReadLine();
                conductores[i].SetNombre(auxNombre);

                for (int j = 0; j < 7; j++)
                {
                    //Console.Write("Ingrese el dia para cargar los kms (1-7): ");
                    //auxDiaString = Console.ReadLine();
                    //int.TryParse(auxDiaString, out auxDia);

                    Console.Write($"Ingrese los kms a cargar para el dia {j+1}: ");
                    auxKmsString = Console.ReadLine();
                    int.TryParse(auxKmsString, out auxKms);

                    //conductores[i].CargarKms(auxDia, auxKms);
                    conductores[i].CargarKms(j+1, auxKms);
                }
            }
            for (int i = 0; i < conductores.Length; i++)
            {
                if (i==0 || conductores[i].KmsSemanales() > maxKms)
                {
                    maxKms = conductores[i].KmsSemanales();
                    maxKmsConductor = conductores[i].GetNombre();
                }
            }

            Console.WriteLine($"El conductor que mas kms hizo esta semana fue: {maxKmsConductor}, que recorrió {maxKms} kms");
        }
    }
}
