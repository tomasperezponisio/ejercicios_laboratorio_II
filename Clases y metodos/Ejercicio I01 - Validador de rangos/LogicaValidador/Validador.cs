using System;

namespace LogicaValidador
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool todoOk = false;

            if (valor > min && valor < max)
            {
                todoOk = true;
            }

            return todoOk;
        }
    }
}
