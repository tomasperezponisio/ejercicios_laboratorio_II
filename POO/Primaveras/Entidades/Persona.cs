using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        // Atributos
        private string nombre;
        private string fechaDeNacimiento;
        private string dni;
        // Constructores
        public Persona(string nombre, string fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public Persona() : this("", "", "")
        {

        }
        public static string Formato()
        {
            return "d/M/yyyy";
        }
        // Setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaDeNacimiento(string fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        // Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public string GetDni()
        {
            return this.dni;
        }

        // Metodos
        private int CalcularEdad()
        {
            int edad = 0;
            // no se como manejar si el formato no es valido <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            DateTime fechaNac = DateTime.ParseExact(this.fechaDeNacimiento, Formato(), null);
            try
            {
                TimeSpan edadCalc = DateTime.Today - fechaNac;
                edad = edadCalc.Days / 365;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("La fecha ingresada esta en un formato invalido");
                //edad = -1;
            }

            return edad;
        }
        public string Mostrar()
        {
            return $"{this.GetNombre()}, nació el {this.GetFechaDeNacimiento()}, tiene {this.CalcularEdad()} años.";
        }
        public string EsMayorDeEdad()
        {
            string mensaje;
            if (this.CalcularEdad() >= 18)
            {
                mensaje = "es mayor de edad";
            }
            else
            {
                mensaje = "es menor";
            }
            return mensaje;
        }

    }
}
