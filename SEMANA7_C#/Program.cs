using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            //DECLARAMOS VARIABLES
            int Contador = 1, Acumulado = 0;
            int edad;
            double promedio;

            for (Contador = 0; Contador <= 34; Contador++)
            {
                Console.WriteLine("Buen día. Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());
                Acumulado = Acumulado + edad;


            }
            promedio = Acumulado / 34;
            Console.WriteLine("El promedio de la edad es: "+ promedio);
        }
    }
}
