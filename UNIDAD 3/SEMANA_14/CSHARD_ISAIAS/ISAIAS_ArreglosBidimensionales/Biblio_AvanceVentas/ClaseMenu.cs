using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_AvanceVentas
{
    public class ClaseMenu
    {
        //Metodo para presentar el menu principal de manera estatica
        public static void MenuPrincipaDinamico()
        {
            string[] menuPrincipal = { "REGISTRAR", "VENTA", "REPORTE", "MODIFICAR", "SALIR" };

            int controlFila = 0, indice = 0;

            ClaseInterfaz.Interfaz();

            ConsoleKey tecla;

            for (int i = 0; i < menuPrincipal.Length; i++)
            {
                if (indice == i)
                {
                    Console.SetCursorPosition(controlFila, 3);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  " + menuPrincipal[i] + "  ");
                    Console.ResetColor();
                }
                else
                {
                    Console.SetCursorPosition(controlFila, 3);
                    Console.Write("  " + menuPrincipal[i] + "  ");
                }

                controlFila = controlFila + 18;
            }

            //Continuar para que el menu cambie de opcion con las teclas de derecha e izquierda
            //No olvidar la Est. Repetitiva Do{} while();

            ConsoleKeyInfo Info = Console.ReadKey(true);
            tecla = Info.Key;




            Console.SetCursorPosition(0, 32);

        }

        //Metodo para presentar el menu principal de manera estatica
        public static void MenuPrincipalEstatico()
        {
            string[] menuPrincipal = { "REGISTRAR", "VENTA", "REPORTE", "MODIFICAR", "SALIR" };

            int controlFila = 0;

            ClaseInterfaz.Interfaz();

            for (int i = 0; i < menuPrincipal.Length; i++)
            {
                Console.SetCursorPosition(controlFila, 3);
                Console.Write("  " + menuPrincipal[i]);
                controlFila = controlFila + 18;
            }
            Console.SetCursorPosition(0, 32);

        }
    }
}
