using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class CLASE
    {
        int[] numeros = new int[0];
        int pos = 0;

        public int Buscar(int Num) 
        {
            for (int i = 0; i < numeros.Length; i++) 
            {
                if (numeros[i] == Num) 
                {
                   return i;
                }
            }
            return -1;
        }

        public void Modificar() 
        {
            Console.Write("\nIngrese el número a modificar: ");
            int n = int.Parse(Console.ReadLine());

            int indice = Buscar(n);

            if (indice != -1)
            {
                Console.Write("\nIngrese el nuevo número: ");
                numeros[indice] = int.Parse(Console.ReadLine());
            }
            else Console.WriteLine("\nNo existe. ");
        }
        public void Eliminar()
        {
            Console.Write("\nIngrese el número a eliminar: ");
            int n = int.Parse(Console.ReadLine());

            int indice = Buscar(n);

            if (indice != -1)
            {
                for (int i = indice; i < numeros.Length; i++)
                {
                    numeros[i] = numeros[i + 1];
                }

                Array.Resize(ref numeros, numeros.Length - 1);
                pos--;
            }
            else Console.WriteLine("\nNo existe. ");

        }
    }
}
