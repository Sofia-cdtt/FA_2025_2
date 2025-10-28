using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejer7
    {
        static void Main(string[] args) 
        {
            // 7.Implemente un programa que genere N números enteros aleatorios entre
            // 0 y 50, los almacene en un arreglo y los muestre. Luego, permita al usuario
            // ingresar un número para verificar si existe en el arreglo generado.

            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int[] numeros = new int[cant];
            Random rnd = new Random();

            Console.WriteLine("\nLista aleatoria: ");
            for (int i = 0; i < numeros.Length; i++) 
            {
                numeros[i] = rnd.Next(1,51);
                Console.WriteLine(numeros[i]);
            }

            Console.Write("\nIngrese el número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            bool b = false;
            for (int i = 0; i<numeros.Length; i++) 
            {
                if (numeros[i] == buscar)
                {
                    b = true;
                }
                    
            }
            if (b == true)
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No existe");
        }
    }
}
