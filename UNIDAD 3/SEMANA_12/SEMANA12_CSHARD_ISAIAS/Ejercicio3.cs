using System;


namespace SEMANA12_CSHARD_ISAIAS
{
    internal class Ejercicio3
    {
        // Insertar un nuevo valor al arreglo pero depende de la posición
        // se correrá 10,20,30,40 agrego índice 3 valor 6
        // ahora sera 10, 20,6,30,40 
        
        // Creación de un arreglo en un método
        public static int[] valorNum = { 10, 20, 30, 40, 50 };

        static void Main(string[] args) 
        {
            int Posición, valor;

            ListaArreglos();

            Console.Write("\nIngrese la posición: ");
            Posición = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            ClaseMenú3.ReemplazarPosición(Posición,valor);

            ListaArreglos();

        }

        static void ListaArreglos() 
        {
            for (int i = 0; i < valorNum.Length ;i++) 
            {
                Console.Write(valorNum[i] + " | ");
            }
        }
    }
}
