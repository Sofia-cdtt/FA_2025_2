using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc5
    {
        static void Main(string[] args) 
        {
            //5.Elabore un programa que permita al usuario definir la cantidad N de
            // números enteros que desea ingresar. El sistema debe registrar esos
            // valores, calcular y mostrar la suma total de todos los números ingresados.

            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] numeros = new int[cant];
            int suma = 0;

            for (int i = 0; i < cant; i++) 
            {
                Console.WriteLine($"Ingrese número {i + 1} : ");
                numeros[1] = int.Parse(Console.ReadLine());
                suma += numeros[1];
            }

            Console.WriteLine("\nNúmeros ingresados: ");
            foreach (int i in numeros) 
                Console.Write(i + " ");
            Console.WriteLine("\n\nSuma total: "+suma);

            
        }
    }
}
