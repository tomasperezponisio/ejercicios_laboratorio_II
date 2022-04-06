using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Tomas", "Perez", "Armenia 1260", "1157405740");
            Cliente c2 = new Cliente("Juan", "Gonzalez", "Alvear 351", "2983401986");
            Cliente c3 = new Cliente("Maria", "Lopez", "Niceto Vega 123", "1140154015");

            c1.AgregarMascota("Perro", "Bobby", "1/1/2020");
            c2.AgregarMascota("Gato", "Chatran", "2/2/2019");
            c3.AgregarMascota("Gato", "Rayita", "3/3/2018");
            c3.AgregarMascota("Perro", "Capitan", "4/4/2015");
        }
    }
}
