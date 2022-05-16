﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaquetePesado : Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        {
            get { return false; }
        }

        decimal IAfip.Impuestos
        {
            get 
            {
                return this.costoEnvio * 0.25m; 
            }
        }

        public override decimal AplicarImpuestos()
        {
            return this.Impuestos + this.costoEnvio + ((IAfip)this).Impuestos;
        }
    }
}
