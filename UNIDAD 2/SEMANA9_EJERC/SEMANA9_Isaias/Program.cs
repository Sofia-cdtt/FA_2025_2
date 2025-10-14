using System;
using System.ComponentModel.Design;

namespace SEMANA9_Isaias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Operacion;
            Console.WriteLine("------EJERCICIO TIPO EXAMEN------");

            Operacion = MENU.ElijeOperacion();

            MENU.EjecutaOperacion(Operacion);

            
        }
    }
}
