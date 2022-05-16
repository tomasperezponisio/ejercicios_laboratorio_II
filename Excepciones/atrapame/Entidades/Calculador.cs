using System;

namespace Entidades
{
    public static class Calculador
    {
        public static int Calcular (int n1, int n2)
        {
            int retorno = 0;
            try
            {
                retorno = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                throw; // lanzo lo del catch
                
            }
            return retorno;
        }
    }
}