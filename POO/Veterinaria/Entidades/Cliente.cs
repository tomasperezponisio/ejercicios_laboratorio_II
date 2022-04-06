using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas = new Mascota[5];
        private int cantidadDeMascotas = 0;
        // Constructores
        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            //for (int i = 0; i < mascotas.Length; i++)
            //{
            //    mascotas[i] = new Mascota(null, null, null);
            //}
        }
        public Cliente() : this("", "", "", "")
        {

        }
        // Setters
        public bool SetNombre(string nombre)
        {
            bool todoOk = false;
            if (nombre != null)
            {
                this.nombre = nombre;
                todoOk = true;
            }
            return todoOk;
        }
        public bool SetApellido(string apellido)
        {
            bool todoOk = false;
            if (apellido != null)
            {
                this.nombre = apellido;
                todoOk = true;
            }
            return todoOk;
        }
        public bool SetDomicilio(string domicilio)
        {
            bool todoOk = false;
            if (domicilio != null)
            {
                this.nombre = domicilio;
                todoOk = true;
            }
            return todoOk;
        }
        public bool SetTelefono(string telefono)
        {
            bool todoOk = false;
            if (telefono != null)
            {
                this.nombre = telefono;
                todoOk = true;
            }
            return todoOk;
        }
        public void SumarCantidadDeMascotas()
        {
            this.cantidadDeMascotas++;
        }
        // Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetDomicilio()
        {
            return this.domicilio;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public int GetCantidadDeMascotas()
        {
            return this.cantidadDeMascotas;
        }
        // Metodos
        public bool AgregarMascota(string especie, string nombre, string fechaDeNacimiento)
        {
            bool todoOk = false;
            if (this.GetCantidadDeMascotas() < 5)
            {
                this.mascotas[this.GetCantidadDeMascotas()] = new Mascota(especie, nombre, fechaDeNacimiento);
                this.SumarCantidadDeMascotas();
                todoOk = true;
            }
            return todoOk;
        }

    }
}
