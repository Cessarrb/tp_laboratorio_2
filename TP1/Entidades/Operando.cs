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

            if (double.TryParse(strNumero, out numeroValido))
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

        public string DecimalABinario(double numero)
        {
            string rtn = "Valor invalido";
            string numeroBinario = "";

            if (numero >= 0)
            {
                int binarioAux = (int)Math.Truncate(numero);

                while(binarioAux > 0)
                {
                    numeroBinario = binarioAux % 2 + numeroBinario;
                    binarioAux = binarioAux / 2;
                }

                return numeroBinario;
            }

            return rtn;
        }
        public string DecimalABinario(string numero)
        {
            string rtn = "Valor invalido";
            double numeroAux;

            if (double.TryParse(numero, out numeroAux))
            {
                string numeroBinario = DecimalABinario(numeroAux);
                return numeroBinario;
            }

            return rtn;
        }

        private static bool EsBinario(string binario)
        {
            char[] binarioArray = binario.ToCharArray();
            bool rtn = false;

            if(!string.IsNullOrEmpty(binario))
            {
                for (int i = 0; i < binarioArray.Length; i++)
                {
                    if(binarioArray[i] == '0' || binarioArray[i] == '1')
                    {
                        rtn = true;
                    }
                    else
                    {
                        rtn = false;
                        break;
                    }
                }
            }

            return rtn;
        }

        public string BinarioADecimal(string numero)
        {
            char[] binarioADecimal = numero.ToCharArray();
            double potencia = 0;
            double numeroBinario = 0;
            string rtn = "Valor invalido";
            if(EsBinario(numero))
            {
                for(int i = binarioADecimal.Length - 1; i >= 0; i--)
                {
                    if(binarioADecimal[i] == '1')
                    {
                        numeroBinario = numeroBinario + Math.Pow(2, potencia);
                    }
                    potencia++;
                }
                rtn = numeroBinario.ToString();
            }

            return rtn;
        }
    }
}
