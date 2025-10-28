using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc2
    {
        static void Main(string[] args) 
        {
            // 2.Cree un programa que almacene los siguientes valores enteros en un
            // arreglo: { -2, 5, -1, 0, 8, -6, 3}. El programa debe reemplazar todos los
            // números negativos por cero y mostrar el arreglo resultante.

            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.Write("Lista orignal: ");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.Write("\nLista con reemplazos: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                    num[i] = 0;
                Console.Write(num[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
