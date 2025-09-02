using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio3();
            Console.ReadKey();


        }

        static void ejercicio1()
        {
            //Inicio
            //Declaramos variables:
            string Nombre, Carrera;

            //Proceso
            Console.WriteLine("Buen día, ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera: ");
            Carrera = Console.ReadLine();

            //Salida
            Console.WriteLine($"\n{Nombre}, Bienvenido al curso de Fundamentos de Algoritmo de la carrera {Carrera}");
            //El simbolismo de $ sirve para concatenar por interpolacion 
            // \n es salto de linea
        }
        static void ejercicio2()
        {
            //Declarar variables
            String Nombre = "TuNombre";
            Console.WriteLine("Buen día, Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Su nombre es: " + $"\"{Nombre}\"");
        }
        static void ejercicio3()
        {
            //Declarar variables
            int Num1, Num2, Suma, Resta = 0, Multiplicación;
            double División;

            Console.WriteLine("Buen día, Ingrese el primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            //Operaciones
            Suma = Num1 + Num2;
            Resta = Num1 - Num2;
            Multiplicación = Num1 * Num2;
            División = Num1 / Num2;

            Console.WriteLine("El resultado de la suma es:" + Suma);
            Console.WriteLine("El resultado de la resta es:" + Resta);
            Console.WriteLine("El resultado de la multiplicación es:" + Multiplicación);
            Console.WriteLine("El resultado de la división es:" + División);
            
        }
        static void ejercicio4()
        {
            //Declarar variables
            double Num, Raiz, elevar, cubica;
            int redondeo;

            Console.WriteLine("Buen día, Ingrese un número decimal: ");
            Num = Convert.ToDouble(Console.ReadLine());

            Raiz = Math.Sqrt(Num);
            
        }
        static void ejercicio5()
        {

        }
        static void ejercicio6()
        {

        }
    }
}
