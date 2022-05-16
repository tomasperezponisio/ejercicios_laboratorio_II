using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T item)
        {
            bool retorno = false;
            if (torneo is not null && item is not null)
            {
                foreach (T elemento in torneo.equipos)
                {
                    if (elemento == item)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Torneo<T> torneo, T item)
        {
            return !(torneo == item);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T item)
        {
            if (torneo is not null && item is not null)
            {
                if (torneo != item)
                {
                    torneo.equipos.Add(item);
                    return torneo;
                }
            }
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            foreach (T item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");

            }
            return sb.ToString();
        }



        private string CalcularPartido(T item1, T item2)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            sb.Append($"{item1.nombre} {rnd.Next(0, 10)} | {item2.nombre} {rnd.Next(0, 10)}");

            return sb.ToString();
        }


        public string JugarPartido
        {
            get
            {
                Random r1 = new Random();
                Random r2 = new Random();
                int indice1 = r1.Next(this.equipos.Count);
                int indice2;
                do
                {
                    indice2 = r2.Next(this.equipos.Count);
                } while (indice1 == indice2);

                return this.CalcularPartido(this.equipos[indice1], this.equipos[indice2]);
            }
        }

    }

}
