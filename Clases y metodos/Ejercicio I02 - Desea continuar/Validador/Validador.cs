using System;

namespace LogicaValidador
{
    public class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            bool todoOk = false;

            if (respuesta == 'S')
            {
                todoOk = true;
            }

            return todoOk;
        }
    }
}
