using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos = new string[3];
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        public string Mostrar()
        {
            string mensaje;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre}\n");
            sb.Append($"Direccion: {this.direccion}\n");
            sb.Append($"Genero: {this.genero}\n");
            sb.Append($"Pais: {this.pais}\n");
            sb.Append($"Edad: {this.edad}\n");
            sb.Append($"Cursos: ");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                if (i != 4)
                {
                    sb.Append($"{this.cursos[i]}, ");

                }
                else
                {
                    sb.Append($"{this.cursos[i]}");
                }
            }
            mensaje = sb.ToString();
            return mensaje;
        }

    }
}
