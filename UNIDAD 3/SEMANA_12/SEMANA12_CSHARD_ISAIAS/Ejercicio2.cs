using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12_CSHARD_ISAIAS
{
    internal class Ejercicio2
    {
        // Aquí se Reemplazara un elemento de una posición por otra
        
        // Creación de un arreglo en un método
        public static int[] valorNum = { 10, 20, 30, 40, 50 };

        static void Main(string[] args) 
        {
            int posiciónValor, valor;

            //Llamamos al método listar
            ClaseMenú.ListaArreglo();

            Console.Write("\nIngrese la posición a cambiar: ");
            posiciónValor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el nuevo valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            //Llamamos a nuestro método
            ClaseMenú.ReemplazarValor(posiciónValor, valor);

            //Llamamos al método listar el arreglo
            ClaseMenú.ListaArreglo();
        }
    }
}
