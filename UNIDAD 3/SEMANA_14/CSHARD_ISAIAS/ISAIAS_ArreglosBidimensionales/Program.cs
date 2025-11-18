using System;

namespace ISAIAS_ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Los Arreglos Bidimensionales no se pueden cambiar el tamaño 
            
            //Declaramos un arreglo Bidimensional
            string[,] ArregloNombres;

            //Configurar tamañano del arreglo (#filas, #columnas)
            
            ArregloNombres = new string[3,4];

            // Otro arreglo - todo esto imprimira filas {0,1,2,3,4 }
            //                                          {5,6,7,8,9 }
            int[,] ArregloNumero = { {0,1,2,3,4 }, {5,6,7,8,9 }, {10,11,12,13,14 } }; // Las llaves son el tamaño general del arreglo

            // Hacemmos el recorrido de las filas
            for (int i = 0; i < ArregloNumero.GetLength(0); i++) 
            {
                // Hacemmos el recorrido de las columnas
                for (int j = 0; j < ArregloNumero.GetLength(1); j++) 
                {
                    Console.Write(ArregloNumero[i,j] + "\t");
                }

                // Da un salto de linea
                Console.WriteLine();
            }
        }
    }
}
