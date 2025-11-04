using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12_CSHARD_ISAIAS
{
    internal class ClaseMenú
    {
        public static void ReemplazarValor(int posición,int nuevoValor) 
        {
            Ejercicio2.valorNum[posición -1 ] = nuevoValor;
        }

        // Método para listas mi arreglo
        public static void ListaArreglo() 
        {
            for (int i = 0; i < Ejercicio2.valorNum.Length; i++) 
            {
                Console.Write(Ejercicio2.valorNum[i] + " | ");
            }
        }
    }
}
