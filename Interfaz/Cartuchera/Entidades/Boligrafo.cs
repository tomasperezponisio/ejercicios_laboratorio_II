using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        protected ConsoleColor colorTinta;
        protected float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        { 
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            int caracteres = texto.Length;
            this.UnidadesDeEscritura -= (caracteres * 0.3f);
            EscrituraWrapper ew = new EscrituraWrapper(texto, this.Color);
            return ew;
        }

        public bool Recargar(int unidades)
        {
            bool retorno = false;
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                retorno = true;
            }
            return retorno;
        }
        public override string ToString()
        {
            return $"Es un: {this.GetType().Name} | Color: {this.Color} | Nivel de tinta: {this.UnidadesDeEscritura}";
        }
    }
}
