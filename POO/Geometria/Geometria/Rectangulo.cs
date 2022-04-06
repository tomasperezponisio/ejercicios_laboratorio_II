using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        // Atributos privados
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        // Constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {   
            // asigno y calculo los vertices
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

        // Getters
        public float Area()
        {
            float area;
            int baseRectangulo = Math.Abs( this.vertice3.GetX() - this.vertice1.GetX() );
            int alturaRectangulo = Math.Abs( this.vertice3.GetY() - this.vertice1.GetX() );
            area = baseRectangulo * alturaRectangulo;
            return area;
        }
        public float Perimetro()
        {
            float perimetro;
            int baseRectangulo = Math.Abs(this.vertice3.GetX() - this.vertice1.GetX());
            int alturaRectangulo = Math.Abs(this.vertice3.GetY() - this.vertice1.GetX());
            perimetro = (baseRectangulo + alturaRectangulo) / 2;
            return perimetro;
        }
        
    }
}
