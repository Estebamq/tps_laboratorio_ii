using System;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// recibe los datos y el operador, retornando el resultado si es posible la operacion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, string operador)
        {
            double respuesta = 0;
            char operadorValidado;


            char.TryParse(operador, out operadorValidado);

            switch (ValidarOperador(operadorValidado))
            {
                case '+':
                    respuesta = num1 + num2;
                    break;
                case '-':
                    respuesta = num1 - num2;
                    break;
                case '*':
                    respuesta = num1 * num2;
                    break;
                case '/':
                    respuesta = num1 / num2;
                    break;
            }


            return respuesta;
        }

       
        /// <summary>
        /// valida el operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            switch (operador)
            {
                case '+':
                    retorno = operador;
                    break;
                case '-':
                    retorno = operador;
                    break;

                case '*':
                    retorno = operador;
                    break;
                case '/':
                    retorno = operador;
                    break;

            }
            return retorno;

        }
    }
}
