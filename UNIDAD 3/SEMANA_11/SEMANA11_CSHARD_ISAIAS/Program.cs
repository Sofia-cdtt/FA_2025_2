using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SEMANA11_CSHARD_ISAIAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            //Declaramos variables
            byte edad;

            byte[] edades; //Declarando un arreglo

            //Asignamos variables y mostramos en pantalla

            // edades = new byte[5]; //le asignamos el tamaño del arreglo -> ahora puede almacenar en 5 espacios

            string[] nombres = new string[5]; // si ya sabes los espacios puede hacer esto de frente


            //Haz esto si no sabes la cantidad de espacios del arreglo

            //int cantidadPersonas;

            //Console.WriteLine("Ingrese la cantidad de personas: ");
            //cantidadPersonas = Convert.ToInt32(Console.ReadLine());

            // edades = new byte[cantidadPersonas];


            //Para asinar lo q contiene un arreglo

            string[] Nombres = new string[5] {"Juan", "Ricardo", "Maria", "Job", "Julia" };

            int[] Edad = new int[] {1,2,3,4,5 }; //Tambien se puede 

            double[] Precio = { 25.4, 20, 15.40, 41 };

            //de aqui
            string[] apellidos = new string[5];

            for (int i = 0; i < apellidos.Length; i++) //apellidos.Length para saber el tamaño del arreglo -> puede tmb "i < 5"
            {
                Console.Write("\nIngrese su apellido {0} : ",i);
                apellidos[i] = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine($"\nEres ... "+ Nombres[i] + " " + apellidos[i]);
                
            }
            //aqui

            
            

        }
    }
}
