using System;

namespace SEMANA12_CSHARD_ISAIAS
{
    internal class ClaseMétodo
    {
        //EJERCICIO 1
        
        // Creamos el método para insertar un nuevo elemento a nuestro arreglo,
        // pero antes debemos cambiar el tamaño del arreglo
        public static void InsertarValor(int elemento) 
        {
            // Cambiamos el tamaño del arreglo a uno mas
            Array.Resize(ref Ejercicio1.valorNumero, Ejercicio1.valorNumero.Length + 1);

            // Insertar el elemento a la última posición del arreglo
            Ejercicio1.valorNumero[Ejercicio1.valorNumero.Length - 1] = elemento;
        }

        //Creamos un método para listar nuestro arreglo

        public static void ListaArreglo() 
        {
            for (int i = 0; i < Ejercicio1.valorNumero.Length; i++) 
            {
                Console.Write(Ejercicio1.valorNumero [i] + " | ");
            }
        }

    }
}
