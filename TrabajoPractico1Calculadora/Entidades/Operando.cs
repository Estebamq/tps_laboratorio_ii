using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
      
        private double numero;
       

        

        public Operando(string strNumero)
        {
            this.SetNumero = ValidarNumero(strNumero);
        }

        public Operando(double numero) : this()
        {
            this.SetNumero = numero;
        }

        public Operando()
        {
            this.SetNumero = 0;
        }

       

       
        public double SetNumero
        {

            set
            {
                numero = ValidarNumero(value.ToString()); //con toString() convierto el valor en string
                                                          //porque este numero lo recibo desde el textbox
                                                          //valido que sea un numero
            }

        }
       
          
        /// <summary>
        /// convierte de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string respuesta = "Valor invalido";

            double valorDecimal;

            if (EsBinario(binario) && binario != "")
            {
                valorDecimal = Convert.ToInt32(binario, 2);

                respuesta = valorDecimal.ToString();
            }
            else { return "No es binario"; }

            return respuesta;
        }

        
        /// <summary>
        /// convierte de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            long num;
            string respuesta = "Valor invalido";

            if (numero > 0)
            {
                num = (long)numero;
                respuesta = "";
                while (num != 0)
                {
                    respuesta = (num % 2).ToString() + respuesta;
                    num /= 2;
                }
            }
            else if (numero == 0)
            {
                respuesta = "00";
            }

            return respuesta;

        }

       
        public string DecimalBinario(string strNumero)
        {
            string respuesta = "Valor invalido";

            if (double.TryParse(strNumero, out double num))
            {
                respuesta = DecimalBinario(num);

            }

            return respuesta;
        }

        //sobrecargas
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double respuesta = double.MinValue;
            if (n2.numero != 0)
            {
                respuesta = n1.numero / n2.numero;
            }

            return respuesta;
        }

        
        private double ValidarNumero(string strNumero) //valido el string del setNumero
        {
            double dlNumero;
            if (!double.TryParse(strNumero, out dlNumero)) //si no es un numero pasa un cero en la variable dlNumero
            {
                dlNumero = 0;
            }

            return dlNumero;
        }

        
        private bool EsBinario(string strBinario)
        {
            foreach (char charBinario in strBinario.ToCharArray())
            {
                if (charBinario != '0' && charBinario != '1')
                {
                    return false;
                }

            }
            return true;
        }


       

    }
}
