using System;

namespace LogicaCalculadora
{
    public class Calculadora
    {
        public static decimal Calcular(decimal operandoA, decimal operandoB, char operacion)
        {
            decimal resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = operandoA + operandoB;
                    break;
                case '-':
                    resultado = operandoA - operandoB;
                    break;
                case '*':
                    resultado = operandoA * operandoB;
                    break;
                case '/':
                    if (Validar(operandoB))
                    {
                        resultado = operandoA / operandoB;
                    }
                    else
                    {
                        Console.WriteLine(" ** ERROR ** No se puede dividir por CERO");
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(decimal operandoB)
        {
            bool todoOk = false;
            if (operandoB != 0)
            {
                todoOk = true;
            }
            return todoOk;
        }
    }
}
