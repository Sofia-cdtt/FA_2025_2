using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_CSHARD_ISAIAS
{
    internal class Prueba
    {
       
        public Prueba() 
        {
            string[] Nombres = new string[5] { "Juan", "Ricardo", "Maria", "Job", "Julia" };

            string[] apellidos = new string[5];

            for (int i = 0; i < apellidos.Length; i++) //apellidos.Length para saber el tamaño del arreglo -> puede tmb "i < 5"
            {
                Console.Write("Ingrese su apellido {0} : ", i);
                apellidos[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(Nombres[i] + apellidos[i]);
            }

        }

    }
}
