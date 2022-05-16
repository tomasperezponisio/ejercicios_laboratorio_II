using System;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo; // Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.

        public Sobrescrito() // Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad // Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        {
            get;           
        }
        public abstract string MiMetodo(); // Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }

    }

}
