using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        public string titular;
        public decimal cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal Cantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"titular: {this.titular}, cantidad: {this.cantidad}";
        }

        //static string Mostrar(Cuenta cuenta)
        //{
        //    return $"titular: {cuenta.titular}, cantidad: {cuenta.cantidad}";
        //}

        public void Ingresar(decimal montoAIngresar)
        {
            if (montoAIngresar > 0)
            {
                this.cantidad += montoAIngresar;
            }
        }

        public void Retirar(decimal montoARetirar)
        {
            if (montoARetirar > 0  && montoARetirar <= this.cantidad)
            {
                this.cantidad -= montoARetirar;
            }
        }
    }
}
