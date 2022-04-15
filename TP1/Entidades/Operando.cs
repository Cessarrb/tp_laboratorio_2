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

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperador(value);
            }
        }

        private double ValidarOperador(string strNumero)
        {
            double numeroValido = 0;

            if(double.TryParse(strNumero, out numeroValido))
            {
                return numeroValido;
            }
            return numeroValido;
        }

        public static double operator +(Operando num1, Operando num2)
        {
            double retorno = num1.numero + num2.numero;

            return retorno;
        }
        public static double operator -(Operando num1, Operando num2)
        {
            double retorno = num1.numero - num2.numero;

            return retorno;
        }
        public static double operator *(Operando num1, Operando num2)
        {
            double retorno = num1.numero * num2.numero;

            return retorno;
        }
        public static double operator /(Operando num1, Operando num2)
        {
            double retorno = 0;

            if (num2.numero != 0)
            {
                retorno = num1.numero / num2.numero;
            }

            return retorno;
        }


    }
}
