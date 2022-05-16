using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        // atributos
        private List<IAduana> impuestosAduana;
        public List<IAfip> impuestosAfip;

        //constructor
        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        // metodos
        public void RegistrarImpuestos( IEnumerable<Paquete> paquetes )
        {
            foreach (Paquete p in paquetes)
            {
                this.RegistrarImpuestos(p);
            }
            
        }
        public void RegistrarImpuestos( Paquete paquete )
        {
            impuestosAduana.Add(paquete);    
            
            if (paquete is IAfip)
            {
                impuestosAfip.Add( (IAfip)paquete );
            }
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            decimal resultado = 0;
            foreach (Paquete item in this.impuestosAduana)
            {
                resultado += item.Impuestos;
            }
            return resultado;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal resultado = 0;
            foreach (Paquete item in this.impuestosAfip)
            {
                resultado += ((IAfip)item).Impuestos;
            }
            return resultado;
        }





    }
}
