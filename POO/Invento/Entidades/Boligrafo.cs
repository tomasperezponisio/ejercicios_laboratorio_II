using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        public const short cantidadTintaMaxima = 100;

        // poner el constructor


        //metodos 
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta <= cantidadTintaMaxima)
            {
                if (tinta > 0)
                {
                    this.tinta += tinta;
                }
                else
                {
                    this.tinta -= tinta;
                }
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool todoOk = false;
            dibujo = null;
            StringBuilder sb = new StringBuilder(); 

            if (gasto <= this.tinta)
            {
                if (this.tinta <= 0)
                {
                    dibujo = "";
                }
                else
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        sb.Append("*");
                    }
                    dibujo = sb.ToString();
                    this.tinta -= gasto;
                    //this.SetTinta(gasto);
                    Console.WriteLine(dibujo);
                }
            }
            return todoOk;
        }
    }
}
