using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        // Atributos
        private string especie;
        private string nombre;
        private string fechaDeNacimiento;
        private string historialDeVacunacion;
        // Constructor
        public Mascota(string especie, string nombre, string fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.historialDeVacunacion = null;
        }
        // Getters

        // Setters
        public bool SetVacuna(string vacuna)
        {
            bool todoOk = false;
            if (vacuna == null)
            {
                this.historialDeVacunacion = vacuna;
                todoOk = true;
            }
            return todoOk;
        }
        // Metodos

    }
}
