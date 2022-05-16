using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        // Atributos
        public enum EPuesto { Caja1, Caja2 };
        private static int numeroActual;
        private EPuesto puesto;
        // Propiedades
        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }
        // Constructores
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        // Metodos
        public bool Atender (Cliente cliente)
        {
            Thread.Sleep(5000);
            return true;
        }
    }
}
