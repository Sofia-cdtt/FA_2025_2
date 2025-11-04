using System;


namespace SEMANA12_CSHARD_ISAIAS
{
    internal class Ejercicio1
    {
        // Aquí vemos todo lo de Insertar un elemento al final de un vector
        
        //Declaramos un arreglo global
        public static int[] valorNumero = new int[0];
        
        static void Main(string[] args)
        {
            int número;
            char Seguir;

            do
            {
                //Pedimos que se ingrese un nuevo valor al arreglo
                Console.Write("\nIngrese un número entero: ");
                número = Convert.ToInt32(Console.ReadLine());

                // Llamamos al método
                ClaseMétodo.InsertarValor(número);

                Console.WriteLine("El valor ingresado es: " + valorNumero[0]);

                //Preguntamos si desea seguir
                Console.Write("\n¿Desea seguir? [S/N]: ");
                Seguir = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (Seguir == 'S');

            Console.BackgroundColor = ConsoleColor.Magenta; //subrayado
            Console.ForegroundColor = ConsoleColor.White; //cambiar el color de texto
            Console.WriteLine("\nEl tamaño del arreglo es: "+valorNumero.Length);
            Console.ResetColor(); //Retorna el color al color inicial

            ClaseMétodo.ListaArreglo();
        }
    }
}
