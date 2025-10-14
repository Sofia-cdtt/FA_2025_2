using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmetica
{
    public class Aritmeticas
    {
        //Método con retorno y parámetros para SUMAR
        public static int Sumar(int valor1, int valor2) 
        {
            return (valor1 + valor2);
        }

        //Método con retorno y parámetros para RESTAR
        public static int Restar(int valor1, int valor2)
        {
            return (valor1 - valor2);
        }

        //Método con retorno y parámetros para MULTIPLICAR
        public static double Multiplicar(int valor1, int valor2)
        {
            return (valor1 * valor2);
        }

        //Método con retorno y parámetros para DIVIDIR
        public static double Dividir(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Error. No se puede dividir un número entre cero.");
                return 0;
            }
            else 
            {
                return (valor1 / valor2);
            }
        }

        //Método con retorno y parámetros para POTENCIA
        public static double Potencia(int valor1, int valor2)
        {
            int Contador;
            double Acumulador = 1;

            for (Contador = 0; Contador <= valor1; Contador++) 
            {
                Acumulador *= valor1;
            }
            return (Acumulador);
        }
    }
}
