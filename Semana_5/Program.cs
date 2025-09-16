using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio4();
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            //Declaramos variables
            int edad;

            //Desarrollo
            Console.WriteLine("Buen día, Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 25)
            {
                Console.WriteLine("Eres candidato para tener un cargo político");
            }

            else if (edad >= 18)
            {
                Console.WriteLine("Si elegible para votar :)");
            }

            else if (edad < 18)
            {
                Console.WriteLine("No eres elegible para poder votar");
            }

        }

        static void Ejercicio2()
        {
            //Declarar variables
            double num1, num2, num3;

            //Desarrollo
            Console.WriteLine("Buen díá. Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Buen díá. Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Buen díá. Ingrese el tercero número: ");
            num3 = double.Parse(Console.ReadLine());

            //Desarrollo
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("El triángulo es Equilátero");
            }

            else if (num1 == num2 || num3 == num2 || num1 == num3)
            {
                Console.WriteLine("El triángulo Isósceles");
            }

            else if (num1 != num2 || num3 != num2 || num1 != num3)
            {
                Console.WriteLine("El triángulo Escaleno");
            }
        }

        static void Ejercicio3()
        {
            //Declaramos variables
            int num1, suma = 0;

            //Desarrollo
            Console.WriteLine("Ingrese un número positivo: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                for (int i = 0; i <= num1; i += 2)
                {
                    suma += i;
                }
                Console.WriteLine("La suma es :" + suma);
            }
            else
            {
                Console.WriteLine("Su número es negativo.");
            }

        }

        static void Ejercicio4()
        {
            //Declaramos
            int num;
            int suma = 0;

            //Desarrollo
            Console.WriteLine("Buen día. Ingrese la cantidad de números a ingresar: ");
            num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= num; i += 2)
            {
               suma += i;
            }
            Console.WriteLine("La suma es :" + suma);
        }

    }
}
