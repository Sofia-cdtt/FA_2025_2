using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Vocales = new char[] {'A', 'E', 'I', 'O', 'U'};
            char letra;

            Console.WriteLine("Ingrese letra: ");
            letra = char.Parse(Console.ReadLine().ToUpper());
            Validacion(letra);
        }

        public static void Validacion(char letra)
        {
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                Console.WriteLine("Sí es una vocal :)");
            }
            else
            {
                Console.WriteLine("No es una vocal");
            }
        }
    }
}
