using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        #region Constructores
        public Numero() : this("0")
        {

        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public Numero(double numero):this(numero.ToString())
        {
        }
        #endregion

        //Metodos

        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }

        // Los operadores realizarán las operaciones correspondientes entre dos números.
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
                retorno = n1.numero / n2.numero;
            return retorno;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            double aux;
            int aux2;
            bool esNumero = double.TryParse(binario, out aux);

            if (esNumero)
            {
                aux2 = (int)aux;
                retorno = CalcularDecimal(aux2.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        static string CalcularDecimal(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double aux;
            int aux2;
            bool esNumero = double.TryParse(numero, out aux);
            if (esNumero)
            {
                aux2 = (int)aux;
                retorno = CalcularBinario(aux2);
            }
            return retorno;
        }

        public string DecimalBinario(double numero)
        {
            string strNumero = numero.ToString();
            return DecimalBinario(strNumero);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entero"></param>
        /// <returns></returns>
        static string CalcularBinario(int entero)
        {
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }
    }

    
}
