using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Estudiantes
    {
        string[] NOMBRES = new string[0];
        byte[] EDADES = new byte[0];
        int pos = 0;

        public void Registrar() 
        {
            byte edad;
            string nombre;



            while (true)
            {
                Console.Write("\nIngrese edad: ");
                if (byte.TryParse(Console.ReadLine(), out edad) & edad >= 0 && edad <= 120) break;

                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Ingrese una edad correcta!\n");
                    Console.ResetColor();
                }                   
            }

            Array.Resize(ref EDADES, EDADES.Length + 1);
            EDADES[pos] = edad;
            pos++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEdad registrada correctamente. ");
            Console.ResetColor();
        }

        public void Mostrar() 
        {
            Console.WriteLine("\nPOS\tEDAD");

            for (int i = 0; i < EDADES.Length; i++)
            {
                Console.WriteLine(i + "\t" + EDADES[i]);
            }
        }

        public void Buscar() 
        {
            
        }

        public void Modificar()
        {

        }

        public void Eliminar()
        {

        }

        public void Ordenar()
        {
            for (int i = 0; i < EDADES.Length - 1; i++)
            {
                for (int j = 0; j < EDADES.Length - 1 - i; j++)
                {
                    if (EDADES[j] > EDADES[j + 1])
                    {
                        byte temp = EDADES[j];
                        EDADES[j] = EDADES[j + 1];
                        EDADES[j + 1] = temp;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("Se ordeno correctamente. ");
            Console.ResetColor();
        }
    }
}
