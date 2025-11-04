using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12_CSHARD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            Estudiantes e = new Estudiantes();
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
                Console.WriteLine("Menú de opciones: \n");
                Console.WriteLine(" 1. Registrar ");
                Console.WriteLine(" 2. Mostrar ");
                Console.WriteLine(" 3. Eliminar ");
                Console.WriteLine(" 4. Ordenar ");
                Console.WriteLine(" 0. Salir\n ");

                int opc;


                while (true)
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) & opc >= 0 && opc <= 4) break; //si la conversion es correcta sal y agregaló a esta variable opc
                    else Console.WriteLine("¡Ingrese una opción correcta!\n");
                }

                switch (opc)
                {
                    case 0: return;
                    case 1: e.Registrar(); break;
                    case 2: e.Mostrar(); break;
                    case 3: e.Eliminar(); break;
                    case 4: e.Ordenar();  break;
                }

                while (true)
                {
                    Console.Write("¿Desea continuar? [S/N] : ");
                    continuar = Console.ReadLine().ToUpper();
                    if (continuar == "S" || continuar == "N") break;
                    else Console.WriteLine("ERROR. Ingrese solo 's' o 'n'\n");
                }
                Console.WriteLine("\nGracias por utilizar el sistema. ");

            } while (continuar == "S");
            
        }
    }
}
