using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio3();
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            //Declaramos
            int edad;

            //Desarrollo
            Console.WriteLine("Buen díá. Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Es usted menor de edad");
            }

            else if (edad >= 18 && edad >= 64)
            {
                Console.WriteLine("Usted es adulto");
            }

            else 
            {
                Console.WriteLine("Usted es mayor de edad");
            }
        }

        static void Ejercicio2()
        {
            //Declaramos
            int year;

            //Desarrollo
            Console.WriteLine("Buen día. Ingrese el año elegido: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"El año {year} es bisiesto");
            }

            else 
            {
                Console.WriteLine($"El año {year} no es bisiesto");
            }

            //Verificar si es par o impar

            if (year % 2 == 0)
            {
                Console.WriteLine($"El año {year} es par ");
            }
            else 
            {
                Console.WriteLine($"El año {year} es impar");
            }
        }

        static void Ejercicio3()
        {
            //Declaramos
            double monto_pe, monto_usd, monto_eur;
            char opcion;

            //Desarrollo
            Console.WriteLine("Buen día. Ingrese el monto en soles (PEN): ");
            monto_pe = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la moneda a la que desea convertir: ");
            Console.WriteLine("=================");
            Console.WriteLine("[D] - Dólares (USD)");
            Console.WriteLine("[E] - Euros (EUR)");
            Console.WriteLine("=================");

            Console.WriteLine("Ingrese la opción:");
            opcion = char.ToUpper(Console.ReadLine()[0]);

            switch (opcion) 
            {
                case 'D':
                    monto_usd = monto_pe / 3.75;
                    Console.WriteLine($"{monto_pe:F2} PEN = {monto_usd:F2} USD");
                    break;

                case 'E':
                    monto_eur = monto_pe / 4.05;
                    Console.WriteLine($"{monto_pe:F2} PEN = {monto_eur} EUR");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente. ");
                    break;

            }

        }

    }
}
