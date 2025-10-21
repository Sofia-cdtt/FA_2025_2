using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cajero
    {
        double saldo = 1000;

        public double Consultar()
        {
            return saldo;
        }

        public void Depositar(double monto) 
        {
            while (true)
            {

                Console.Write("\nIngrese el monto a depositar: ");
                string en = Console.ReadLine();
            
                try
                {
                    monto = Convert.ToDouble(en);

                    if (monto > 0)
                    {
                        saldo += monto;
                        Console.WriteLine("Deposito exitoso.");
                        break;
                    }

                    else 
                    {
                        Console.WriteLine("ERROR. Tiene que ser un deposito mayor a cero. ");
                        continue; //no lo considera y vuelve a ejecutar el ingreso del monto a depositar
                    }
                        
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR. El deposito tiene que ser un monto válido. ");
                    continue;
                }
            }
            
        }

        public void Retirar(double monto)
        {
            while (true)
            {

                Console.Write("\nIngrese el monto a retirar: ");
                string en = Console.ReadLine();

                try
                {
                    monto = Convert.ToDouble(en);

                    if (monto <= saldo)
                    {
                        saldo -= monto;
                        Console.WriteLine("Retiro exitoso.");
                        break;
                    }
                    else if (monto < 0) 
                    {
                        Console.WriteLine("ERROR. Tiene que ser un retiro mayor a cero.\n");
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("ERROR. Saldo insuficiente\n. ");
                        continue; //no lo considera y vuelve a ejecutar el ingreso del monto a depositar
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR. El retiro tiene que ser un monto válido. ");
                    continue;
                }
            }

        }
    }
}
