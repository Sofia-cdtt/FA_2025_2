using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc4
    {
        static void Main(string[] args) 
        {
            // 4.Cree un programa que permita al usuario ingresar 10 números enteros y
            // luego muestre solamente los números que sean pares.

            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese un número {i + 1} : ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nLISTA DE PARES:");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    Console.WriteLine(num[i]);
            }
        }
    }
}
