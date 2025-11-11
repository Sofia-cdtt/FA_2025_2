using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class deCLASE
    {
        static void Main(string[] args) 
        {
            int opc;
            

            while (true)
            {
                Console.Clear();
                Menu();
                Console.Write("Ingrese opción: ");
                opc = Console.ReadKey().KeyChar;
                if (opc >= '1' && opc <= '5') break;
            }
            Console.WriteLine("\nHola");
        }

        static void Menu() 
        {
            Console.WriteLine("=== MENÚ LIBRERIA ===");
            Console.WriteLine("1. Registrar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Modificar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir\n"); 
        }
    }
}
