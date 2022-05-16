﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retorno = false;
            if (e1 is not null && e2 is not null)
            {
                if (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion}";
        }
    }
}
