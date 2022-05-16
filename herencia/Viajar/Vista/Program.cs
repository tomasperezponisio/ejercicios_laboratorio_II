using System;
using System.Collections.Generic;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(6, 2, VehiculoTerrestre.Colores.Rojo, 8, 15000);
            Automovil auto = new Automovil(4, 4, VehiculoTerrestre.Colores.Blanco, 5, 3);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Azul, 250);

            List<VehiculoTerrestre> lista = new List<VehiculoTerrestre>();

            lista.Add(camion);
            lista.Add(auto);
            lista.Add(moto);

            foreach (VehiculoTerrestre vehiculo in lista)
            {
                //Console.WriteLine($"El {vehiculo.GetType().Name} tiene {vehiculo.CantidadRuedas} ruedas, {vehiculo.CantidadPuertas} puertas y es de color {vehiculo.Color} ");
                Console.WriteLine( vehiculo.Mostrar() ); 
            }

            lista.Sort(Criterio);
            Console.WriteLine("\n");

            foreach (VehiculoTerrestre vehiculo in lista)
            {
                //Console.WriteLine($"El {vehiculo.GetType().Name} tiene {vehiculo.CantidadRuedas} ruedas, {vehiculo.CantidadPuertas} puertas y es de color {vehiculo.Color} ");
                Console.WriteLine(vehiculo.Mostrar());
            }



            //Console.WriteLine(camion.MostrarInfo()); 

            //auto.Color = VehiculoTerrestre.Colores.Azul;
        }

        public static int Criterio(VehiculoTerrestre a, VehiculoTerrestre b)
        {
            return b.CantidadPuertas - a.CantidadPuertas;
        }
    }
}
