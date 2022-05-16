using System;

namespace Entidades
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje) : base(mensaje)
        { }
        public UnaExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        { }
    }
}
