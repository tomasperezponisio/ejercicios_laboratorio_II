using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException (string mensaje) : base (mensaje)
        {
        }

        public ParametrosVaciosException (string mensaje, Exception inner) : base (mensaje, inner)
        {
        }

    }
}
