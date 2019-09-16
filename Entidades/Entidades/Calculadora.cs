using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            string verificado = ValidarOperador(operador);

            if (verificado == "-")
            {
                retorno = num1 - num2;
            }
            else if (verificado == "+")
            {
                retorno = num1 + num2;
            }
            else if (verificado == "/")
            {
                retorno = num1 / num2;
            }
            else
            {
                retorno = num1 * num2;
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador == "-" || operador == "/" || operador == "*")
                retorno = operador;

            return retorno;
        }
    }
}
