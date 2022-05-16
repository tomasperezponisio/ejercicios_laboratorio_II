using System;

namespace Entidades
{
    public abstract class Paquete : IAduana
    {
        // atributos
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        // propiedades
        public abstract bool TienePrioridad { get; }

        // constructor
        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.pesoKg = pesoKg;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.codigoSeguimiento = codigoSeguimiento;
        }

        // metodos
        public string ObtenerInformacionDePaquete()
        {
            return $"Codigo de seguimiento: {this.codigoSeguimiento} | Costo de envio: {this.costoEnvio} | Origen: {this.origen} | Destino: {this.destino} | Peso: {this.pesoKg}Kg";
        }

        // propiedades de la interfaz
        public decimal Impuestos
        {
            get { return this.costoEnvio * 0.35m; }
        }

        // metodo de la interfaz 
        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos;
        }
    }
}
