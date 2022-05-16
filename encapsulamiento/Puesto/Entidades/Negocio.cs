using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        // Atributos
        private string nombre;
        private Queue<Cliente> clientes;
        private PuestoAtencion caja;
        // Propiedades
        public Cliente Cliente
        {
            get
            {

                return this.clientes.Dequeue();

            }
            set
            {
                bool resultado = value + this;
            }
        }
        public int ClientesPendientes { get { return this.clientes.Count; } }
        // Constructores
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);

        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        // Metodos

        // Operadores
        public static bool operator +(Cliente c, Negocio n)
        {
            if (c != n)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ==(Cliente c, Negocio n)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente c, Negocio n)
        {
            return !(c == n);
        }

        public static bool operator ~(Negocio n)
        {
            if (n.ClientesPendientes > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
    }
}
