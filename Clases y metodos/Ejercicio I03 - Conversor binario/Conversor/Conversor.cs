using System;
using System.Text;

namespace LogicaConversor
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            StringBuilder binarioInvertido = new StringBuilder();
            string binario;
            int dividendo = numeroEntero;
            int resto;
            while (dividendo >= 2)
            {
                resto = dividendo % 2;
                binarioInvertido.Append(resto.ToString());
                dividendo = dividendo / 2;
            }            
            binarioInvertido.Append(dividendo.ToString());            
            binario = invertirString( binarioInvertido.ToString() );

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numeroDecimal = 0;
            int numeroAEvaluar;            
            int sumador;
            StringBuilder numeroEnteroString = new StringBuilder();
            numeroEnteroString.Append(numeroEntero);
            for (int i = numeroEnteroString.Length - 1; i >= 0; i--)
            {
                numeroAEvaluar = int.Parse(numeroEnteroString[i].ToString());
                //Console.Write($"numeroAEvaluar es: {numeroAEvaluar}  |  ");
                //Console.WriteLine($"numeroDecimal es: {numeroDecimal}");
                if (numeroAEvaluar == 0) sumador = 0;
                
                else
                
                    sumador = (int)Math.Pow(2, (numeroEnteroString.Length - 1-i));
                
                //Console.WriteLine($"Sumador es: {sumador}");
                numeroDecimal += sumador;
            }
            return numeroDecimal;
        }

        public static string invertirString(string stringAInvertir)
        {
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = stringAInvertir.Length - 1; i >= 0; i--)
            {
                stringbuilder.Append(stringAInvertir[i]);
            }

            return stringbuilder.ToString();
        }
    }
}