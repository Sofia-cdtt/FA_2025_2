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

            ejercicio6();

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
            redondeo = (int)Math.Round(Num);
            elevar = Math.Pow(Num, 3);
            cubica = Math.Pow(Num, 1 / 3d);

            Console.WriteLine("Su raíz cuadrada es:"+ Raiz);
            Console.WriteLine("Su valor redondeado es: "+ redondeo);
            Console.WriteLine("Su resultado elevado al cubo: "+ elevar);
            Console.WriteLine("Su raíz cubica es: "+ cubica);
            
        }
        static void ejercicio5()
        {
            Console.WriteLine("Ingrese un número: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: " + (entero % 2));
            Console.WriteLine("División" + deci / 3);
        }
        static void ejercicio6()
        {


            //Declaramos variables
            int cantidadSegundos, Horas, minutos, segundosRestantes;

            //DESARROLLO
            Console.WriteLine("Ingrese la cantidad de segundos que quieres transformar:");
            cantidadSegundos = int.Parse(Console.ReadLine());

            //Calcular horas, minutos y segundos restantes
            Horas = cantidadSegundos / 3600;
            minutos = (cantidadSegundos % 3600) / 60;
            segundosRestantes = cantidadSegundos % 60;

            Console.WriteLine("Sus resultados son: ");
            Console.WriteLine("Horas: " + Horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos restantes: "+ segundosRestantes);




        }
    }
}
