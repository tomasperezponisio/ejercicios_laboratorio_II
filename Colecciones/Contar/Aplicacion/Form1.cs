using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            string texto = this.richTextBox1.Text;
            string[] palabras = texto.Split(" ");
            foreach (string palabra in palabras)
            {
                if (!contador.ContainsKey(palabra))
                {
                    contador.Add(palabra, 1);
                }
                else
                {
                    contador[palabra]++;
                }
            }

            int primerPalabraCantidad = 0;
            string primerPalabra = "";
            int segundaPalabraCantidad = 0;
            string segundaPalabra = "";
            int tercerPalabraCantidad = 0;
            string tercerPalabra = "";

            // me fijo la palabra que mas aparece y guardo el numero y el string
            primerPalabraCantidad = contador.Values.Max();

            foreach (KeyValuePair<string, int> palabra in contador)
            {
                if (palabra.Value == primerPalabraCantidad)
                {
                    primerPalabra = palabra.Key;
                }
            }
            // borro la primer palabra del dicccionario
            contador.Remove(primerPalabra);

            // ahora me fijo de vuelta la palabra que mas aparece (seria la segunda)
            if (contador.Count != 0)
            {
                segundaPalabraCantidad = contador.Values.Max();

                foreach (KeyValuePair<string, int> palabra in contador)
                {
                    if (palabra.Value == segundaPalabraCantidad)
                    {
                        segundaPalabra = palabra.Key;
                    }
                }
                // borro la segunda palabra del dicccionario
                contador.Remove(segundaPalabra);
            }
            if (contador.Count != 0)
            {
                // ahora me fijo de vuelta la palabra que mas aparece (seria la tercera)
                tercerPalabraCantidad = contador.Values.Max();

                foreach (KeyValuePair<string, int> palabra in contador)
                {
                    if (palabra.Value == tercerPalabraCantidad)
                    {
                        tercerPalabra = palabra.Key;
                    }
                }
            }
            MessageBox.Show($"TOP 3 de palabras.\n" +
                $"1ra: {primerPalabra} y aparece {primerPalabraCantidad} veces\n" +
                $"2da: {segundaPalabra} y aparece {segundaPalabraCantidad} veces\n" +
                $"3ra: {tercerPalabra} y aparece {tercerPalabraCantidad} veces");

        }
    }
}
