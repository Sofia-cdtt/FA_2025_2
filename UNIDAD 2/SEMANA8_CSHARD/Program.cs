using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_CSHARD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO 1");

            //Llamamos a nuestro método
            ComparaValor();
        }

        //Creamos método sin parámetros y sin retorno
        static void ComparaValor()
        {
            int Valor;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                Valor = Convert.ToInt32(Console.ReadLine());

                if ((Valor % 2) == 0)
                {
                    Console.WriteLine("Número par");
                }
                else
                {
                    Console.WriteLine("Número es impar");
                }
            } while (Valor != 0);

        }
    }
}
