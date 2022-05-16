using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        private string nombre;
        public MiClase()
        {
            try 
            {                
                MiMetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Excepcion del primer constructor", ex );
            }
        }
        public MiClase(string value)
        {
            this.nombre = value;            
            MiClase objeto;
            try
            {
                objeto = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new UnaExcepcion("Excepcion del segundo constructor", ex);
            }            
        }
        // Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        public static void MiMetodoEstatico() 
        {
            throw new DivideByZeroException("el origen de todo ");
        }
    }
}
