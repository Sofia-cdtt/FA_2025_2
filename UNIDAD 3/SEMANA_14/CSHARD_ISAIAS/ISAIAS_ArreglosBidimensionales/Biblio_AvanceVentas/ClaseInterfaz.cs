using System;

namespace Biblio_AvanceVentas
{
    public class ClaseInterfaz
    {
        public static void Interfaz() 
        {
            // Encabezado del programa
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*----------------------------------------------------------------------------------------*");
            Console.WriteLine("|                                    SISTEMA DE VENTA                                    |");
            Console.WriteLine("*----------------------------------------------------------------------------------------*");
            Console.ResetColor();

            //Creamos el espacio para el menu
            Console.SetCursorPosition(0, 4);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                          ");
            Console.ResetColor();

            //Creamos el contorno izquierdo de la interfaz
            for (int i = 5; i < 29; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.ResetColor();
            }
            //Creamos el contorno derecho de la interfaz

            for (int i = 5; i < 29; i++)
            {
                Console.SetCursorPosition(89, i);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.ResetColor();
            }

            //metodo para cerrar la interfaz
            Console.SetCursorPosition(0, 29);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                                                          ");
            Console.ResetColor();
        }
    }
}
