using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAcciones
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract float UnidadesDeEscritura { get; set; }

        public abstract EscrituraWrapper Escribir(string texto);
        public abstract bool Recargar(int unidades);
    }
}
