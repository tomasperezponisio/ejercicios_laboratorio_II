using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = marca;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"marca: {p.marca}, codigo de barra: {p.codigoDeBarra}, precio: {p.precio}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Producto p1, string s)
        {
            bool retorno = false;
            if (p1.marca == s)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, string s)
        {
            bool retorno = false;
            if (p1.marca != s)
            {
                retorno = true;
            }
            return retorno;
        }




    }
}
