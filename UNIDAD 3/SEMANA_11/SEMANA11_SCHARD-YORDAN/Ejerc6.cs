using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc6
    {
        static void Main(string[] args) 
        {
            // 6.Desarrolle un programa que permita registrar los nombres de 5 productos,
            // asegurándose de que no se repita ningún nombre. Si se detecta un
            // nombre duplicado, deberá mostrar un mensaje de advertencia y solicitar
            // un nuevo ingreso.

            string[] producto = new string[5];
            int registro = 0;

            for (int i = 0; registro < producto.Length; i++) 
            {
                Console.Write("Ingrese el nombre del producto: ");
                string pro = Console.ReadLine();
                bool repet = false;

                for (int j = 0; j < producto.Length; j++)
                {
                    if (producto[j] == pro) 
                    {
                        Console.WriteLine("El producto ya existe.\n");
                        repet = true;
                        break; // -> el break sirve para que ya no se siga buscando una coincidencia
                    }
                }

                if (repet == false) 
                {
                    producto[registro] = pro;
                    registro++;
                }
            }

            Console.WriteLine("\nLista de productos: ");
            foreach (string i in producto)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
