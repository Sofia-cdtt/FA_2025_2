using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_CSHARD
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Ingrese número 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese número 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Llamamos al método con parámetros
            CalculaMayor(num1, num2, num3);
        }
        //Construimos el mé´todo con parámetros pero sin retorno
        static void CalculaMayor(int valor1, int valor2, int valor3)
        {
            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("El número mayor es " + valor1);
            }
            else
            {
                if (valor2 > valor1 && valor2 > valor3)
                {
                    Console.WriteLine("El número mayor es " + valor2);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + valor3);
                }
            }
        }
    }
}
