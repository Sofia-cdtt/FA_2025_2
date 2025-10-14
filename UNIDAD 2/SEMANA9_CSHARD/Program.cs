using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA9_CSHARD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            //Declaramos variables
            double MontoPagar;

            Console.Write("Buen día. Ingrese su monto total a pagar: S/ ");
            MontoPagar = Convert.ToDouble(Console.ReadLine());

            CalcularIGV(MontoPagar);

            Console.WriteLine("El monto total del IGV es: " + MontoPagar);
        
        }

        static double CalcularIGV(double MontoPagar) 
        {

            return (MontoPagar *= 0.18);
        }
    }
}
