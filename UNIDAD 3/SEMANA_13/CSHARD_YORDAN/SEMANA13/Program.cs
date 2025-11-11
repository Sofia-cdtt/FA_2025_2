using System;

namespace SEMANA13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] OPCIONES = new string[7] {"Registrar", "Mostrar", "Buscar", "Modificar", "Eliminar", "Ordenar", "Salir"};

            int opcion;
            Estudiantes e = new Estudiantes();
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("*------------------------------------------------------------------------*");
                Console.WriteLine("|                     MENÚ DE GESTIÓN DE ESTUDIANTES                     |");
                Console.WriteLine("*------------------------------------------------------------------------*");
                Console.ResetColor();
                int indice = 0;
                
                ConsoleKey tecla;
                do
                {
                    for (int i = 0; i < OPCIONES.Length; i++)
                    {
                        Console.SetCursorPosition(3, 4 + i);
                        
                        if (i == indice)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(OPCIONES[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(OPCIONES[i]);
                        }
                    }

                    ConsoleKeyInfo info = Console.ReadKey(true);
                    tecla = info.Key;

                    if (tecla == ConsoleKey.DownArrow)
                    {
                        indice++;
                        if (indice > OPCIONES.Length - 1)
                        {
                            indice = 0;
                        }
                    }
                    
                    else if (tecla == ConsoleKey.UpArrow)
                    {
                        indice--;
                        if (indice < 0)
                        {
                            indice = OPCIONES.Length - 1;
                        }
                    }
                } while (tecla != ConsoleKey.Enter);

                for (int i = 0; i < OPCIONES.Length; i++) 
                {
                    Console.SetCursorPosition(4, 4 + i);
                    Console.WriteLine(OPCIONES[i]);
                }                                        
                
                switch (opcion)
                {
                    case 1:
                        e.Registrar();
                        break;
                    case 2:
                        e.Mostrar();
                        break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6:
                        e.Ordenar();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSaliendo del programa...");
                        Console.ResetColor();
                        return;
                }
                if (opcion != 7)
                {
                    Console.SetCursorPosition(4, 18);
                    Console.Write("Presione una tecla para regresar al menú...");
                    Console.ReadKey();
                }
            } while (opcion != 7);
        }
    }
}
