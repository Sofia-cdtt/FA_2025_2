using System;
using System.Diagnostics;
using Biblioteca;

namespace SEMANA10_CSHARD
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Cajero c = new Cajero();
                int opc;
                string seguir;

            do
            {

                Console.WriteLine("BIENVENIDO AL SISTEMA DE CAJERO\n");
                Console.WriteLine("1. Consultar saldo. ");
                Console.WriteLine("2. Depositar dinero. ");
                Console.WriteLine("3. Retirar dinero. ");
                Console.WriteLine("4. Salir. ");

                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc = int.Parse(Console.ReadLine());

                    if (opc < 0 | opc > 4)
                    {
                        Console.WriteLine("Opción no válida. Ingrese nuevamente\n");
                    }

                } while (opc < 0 | opc > 4); // puede ser || o |

                switch (opc)
                {
                    case 1: Console.WriteLine("\nSaldo disponible: " + c.Consultar()); break;
                    case 2: c.Depositar(0); break;
                    case 3: c.Retirar(0); break;
                    case 4: return;
                }

                while (true)
                {
                    Console.WriteLine("\n¿Desea continuar? (s/n): ");
                    seguir = Console.ReadLine().ToUpper();

                    if (seguir != "S" & seguir != "N")
                    {
                        Console.WriteLine("ERROR. Solo permiten 's' o 'n'. ");
                    }
                    else break;
                }
                Console.Clear();
            } 
            while (seguir == "S");
        }
    }
}
