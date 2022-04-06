using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conductor
    {
        // Atributos
        private string nombre;
        private int[] kmsSemanales = new int[7];
        // Constructor
        public Conductor()
        {
            this.nombre = "";
            for (int i = 0; i < this.kmsSemanales.Length; i++)
            {
                this.kmsSemanales[i] = 0;
            }
        }
        // Setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void CargarKms(int dia, int kms)
        {
            if (dia < 1 || dia > 7)
            {
                Console.WriteLine("Ingresó un dia invalido");
            }
            else
            {
                switch (dia)
                {
                    case 1:
                        this.kmsSemanales[0] += kms;
                        break;
                    case 2:
                        this.kmsSemanales[1] += kms;
                        break;
                    case 3:
                        this.kmsSemanales[2] += kms;
                        break;
                    case 4:
                        this.kmsSemanales[3] += kms;
                        break;
                    case 5:
                        this.kmsSemanales[4] += kms;
                        break;
                    case 6:
                        this.kmsSemanales[5] += kms;
                        break;
                    case 7:
                        this.kmsSemanales[6] += kms;
                        break;
                }
            }
        }
        // Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetKms(int dia)
        {
            int kms = -1;            
            if (dia < 1 || dia > 7)
            {
                Console.WriteLine("Ingresó un dia invalido");
            }
            else
            {
                switch (dia)
                {
                    case 1:
                        kms = this.kmsSemanales[0];
                        break;
                    case 2:
                        kms = this.kmsSemanales[1];
                        break;
                    case 3:
                        kms = this.kmsSemanales[2];
                        break;
                    case 4:
                        kms = this.kmsSemanales[3];
                        break;
                    case 5:
                        kms = this.kmsSemanales[4];
                        break;
                    case 6:
                        kms = this.kmsSemanales[5];
                        break;
                    case 7:
                        kms = this.kmsSemanales[6];
                        break;
                }
            }
            return kms;
        }
        // Metodos
        public int KmsSemanales()
        {
            int kms = 0;
            for (int i = 0; i < this.kmsSemanales.Length; i++)
            {
                kms += this.kmsSemanales[i];
            }
            return kms;
        }

    }
}
