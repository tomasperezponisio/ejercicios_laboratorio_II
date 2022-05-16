using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        // Atributos
        private string nombre;
        private int numero;
        // Propiedades
        public string Nombre { get { return this.Nombre; } set { this.Nombre = value; } }
        public int Numero { get { return this.Numero; } }
        // Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        // Operadores
        public static bool operator ==(Cliente c1, Cliente c2)  
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
