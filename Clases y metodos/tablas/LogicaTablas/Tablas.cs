using System;
using System.Text;

namespace LogicaTablas
{
    public class Tablas
    {
        public static string Calcular(int numero)
        {
            string tabla;
            StringBuilder armadoTabla = new StringBuilder();
            Console.Clear();            
            armadoTabla.Append($"Tabla de multiplcar del numero {numero}\n");
            for (int i = 0; i < 10; i++)
            {
                armadoTabla.Append($"{numero} X {i} = {numero * i}\n");
            }
            tabla = armadoTabla.ToString();

            return tabla;
        }
    }
}
