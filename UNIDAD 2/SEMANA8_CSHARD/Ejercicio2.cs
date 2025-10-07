using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_CSHARD
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            double sueldo, porc_descuento, descuento;

            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            porc_descuento = CalculaPorcentaje();
            descuento = sueldo * porc_descuento;
            Console.WriteLine("El monto descuento es: " + descuento);
        }
        static double CalculaPorcentaje()
        {
            string pension;
            double porcentaje = 0;

            Console.WriteLine("Ingrese su pensión (AFP/ONP): ");
            pension = Console.ReadLine().ToUpper();

            if (pension == "AFP")
            {
                porcentaje = 0.12;
            }
            else
            {
                porcentaje = 0.08;
            }

            return porcentaje;
        }

    }
}
