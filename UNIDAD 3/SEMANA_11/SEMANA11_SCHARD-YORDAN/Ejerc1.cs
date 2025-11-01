using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc1
    {
        static void Main(string[] args)
        {
            //1.Desarrolle un programa que permita al usuario ingresar 5 números
            //enteros y, posteriormente, muestre en pantalla todos los valores ingresados.

            //INICIO
            //Asignamos variables
            int[] num = new int[5];

            //Mostramos en pantalla
            
            for (int i = 0; i < num.Length; i++) 
            {
                Console.Write($"Ingrese un número {i+1} : ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nLa lista de valores ingresados son: ");

            foreach (int i in num) 
                Console.WriteLine(i + " ");
            Console.ReadKey();
            
        }
    }
}
