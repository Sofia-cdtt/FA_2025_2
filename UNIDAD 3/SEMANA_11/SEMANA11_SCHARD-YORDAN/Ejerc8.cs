using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc8
    {
        static void Main(string[] args) 
        {
            // 8.Cree un programa que almacene los siguientes nombres en un arreglo:
            // { José, óscar, Carmen, Alexa}. Posteriormente, permita al usuario ingresar
            // uno de estos nombres y, si existe en el arreglo, permitir modificarlo por otro.

            string[] nombres = new string[4] { "\nJosé", "óscar", "Carmen", "Alexa" };

            Console.Write("\nLista de nombres actuales: ");
            foreach (string nombre in nombres)
                Console.WriteLine(nombre);
            
            Console.Write("\nIngrese un nombre: ");
            string Buscando = Console.ReadLine();
            Console.Clear();

            int índice = Array.IndexOf(nombres, Buscando);

            if (índice != -1)
            {
                Console.Write("\nIngrese el nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();

                nombres[índice] = nuevoNombre;

                Console.WriteLine("\nNombre modificado con éxito.");
            }

            else 
            {
                
                Console.Write("\nEl nombre no se encuentra en la lista. ");
            }

            Console.WriteLine("\nLista actualizada:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

        }
    }
}
