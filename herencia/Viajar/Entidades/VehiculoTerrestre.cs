using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro };        
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public short CantidadRuedas { get { return this.cantidadRuedas; } set { this.cantidadRuedas = value; } }
        public short CantidadPuertas { get {return this.cantidadPuertas; } set { this.cantidadPuertas = value; } }
        public Colores Color { get { return this.color; } set { this.color = value; } }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
        }

        public string Mostrar()
        {
            return $"Cantidad de ruedas: {this.CantidadRuedas}, Cantidad de puertas: {this.CantidadPuertas} y color: {this.Color}";
        }
    }
}
