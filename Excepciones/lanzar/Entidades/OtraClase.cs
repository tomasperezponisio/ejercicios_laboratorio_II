using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MiMetodoInstancia()
        {
            MiClase objeto;
            try
            {
                objeto = new MiClase("sarasa");
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion de OtraClase", ex);
            }
        }
    }
}
