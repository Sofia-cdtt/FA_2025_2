using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_SCHARD_YORDAN
{
    internal class Ejerc3
    {
        public void Main(string[] args) 
        {
            // 3.Implemente un programa que inserte los siguientes valores en un arreglo:
            // { 10, 50, 6, 3, 7, 20}. El sistema debe identificar y mostrar el valor mínimo
            // y máximo del arreglo.

            int[] valores = { 10, 50, 6, 3, 7, 20 };
            Console.Write("Lista orignal: ");
            foreach (int i in valores)
                Console.Write(i + " ");

            int minimo = valores[0];
            int maximo = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] < minimo)
                    minimo = valores[i];
                if (valores[i] > maximo)
                    maximo = valores[i];
            }
            Console.Write("\n");
            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mínimo: " + minimo);
        }
    }
}
