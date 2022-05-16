using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        protected float tamanioMina;
        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int caracteres = texto.Length;
            this.UnidadesDeEscritura-=(caracteres*0.1f);
            EscrituraWrapper ew = new EscrituraWrapper( texto, this.Color );
            return ew;
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Es un: {this.GetType().Name} | Color: {this.Color} | Nivel de tinta: {this.UnidadesDeEscritura}";
        }
    }
}
