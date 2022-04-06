using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante (string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if (nota > 0 && nota <= 10)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota <= 10)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial)
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2.0f;
        }

        public double CalcularNotaFinal(int notaPrimerParcial, int notaSegundoParcial)
        {
            double notaFinal;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }

        public string Mostrar()
        {
            double notaPromedio;
            double notaFinal;
            StringBuilder sb = new StringBuilder();

            notaPromedio = CalcularPromedio(this.notaPrimerParcial, this.notaSegundoParcial);
            notaFinal = CalcularNotaFinal(this.notaPrimerParcial, this.notaSegundoParcial);

            sb.Append($"Alumno: {this.nombre} {this.apellido}, legajo: {this.legajo}\n1er parcial: {this.notaPrimerParcial}, " +
                $"2do parcial: {this.notaSegundoParcial}\nPromedio cursada: {notaPromedio}\nNota final: ");
            if (notaFinal == -1)
            {
                sb.Append("Alumno desaprobado");
            }
            else 
            {
                sb.Append($"{notaFinal}");
            }
            return sb.ToString();
        }
    }
}
