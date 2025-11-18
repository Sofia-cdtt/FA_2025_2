using System;

namespace EJERCICIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;

            while (true) 
            {
                Console.Write("Ingrese nombre 1: ");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1)) break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("No se permiten vacios.\n");
                    Console.ResetColor();
                } 
            }

            while (true) 
            {
                Console.Write("Ingrese nombre 2: ");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2)) break;
                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("No se permiten vacios.\n");
                    Console.ResetColor();
                }                   
            }
            // Calcular la cantidad de caracteres que contiene los apellidos.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nLongitud de nombre 1: "+nom1.Length);
            Console.WriteLine("Longitud de nombre 2: " + nom2.Length);

            // Mostrar los nombres en mayúsculas.
            Console.WriteLine("\nNombre 1 en mayúsculas: "+nom1.ToUpper());

            // Mostrar los nombres en minúsculas.
            Console.WriteLine("Nombre 2 en mayúsculas: " + nom2.ToLower());

            if (nom1.CompareTo(nom2) == 0) Console.WriteLine("\nNombres iguales. ");
            else Console.WriteLine("\nNombres diferentes. ");

            if (nom1.Contains("an")) Console.WriteLine("\nSi contiene 'an'. ");
            else Console.WriteLine("\nNo contiene 'an'. ");
            Console.ResetColor ();

            //Index significa posición - te va devolver la posición de la primera 'a'
            if (nom1.IndexOf("a") != -1)
                Console.WriteLine("\nPrimera posición de 'a': " + nom1.IndexOf("a"));
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo existe 'a'. "); 
                Console.ResetColor();
            }

            // Para ubicar la ultima posicion de 'a'
            if (nom1.LastIndexOf("a") != -1)
                Console.WriteLine("Ultima posición de 'a': " + nom1.LastIndexOf("a"));
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo existe 'a'. ");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nInsertando UPN en nombre 1: "+nom1.Insert(0,"UPN"));
            Console.WriteLine("\nInsertando SISTEMA al final: " + nom2.Insert(nom2.Length, "SISTEMAS"));
            Console.ResetColor();

            if (nom2.Length > 5)
                Console.WriteLine("\nEliminar desde 5ta posición. . ." + nom2.Remove(5));
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo hay al menos 5 caracteres. . .");
                Console.ResetColor();
            }

            if (nom1.Contains("a"))
                Console.WriteLine("\nReemplazando a -> @ : "+nom1.Replace("a","@"));
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo contiene 'a'. . .");
                Console.ResetColor();
            }

            // Dividir el texto desde la letra “a” en apellidos. Si o hay la letra “a” mostrar
            // mensaje “no contiene la letra “a”.
            if (nom1.Contains("a"))
            {
                Console.Write("\nDividido en partes: ");
                string[] partes = nom1.Split('a');
                for (int i = 0; i < partes.Length; i++)
                    Console.Write(partes[i]+ " -> ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNo contiene 'a'. . .");
                Console.ResetColor();
            }

            // Mostrar una sub-cadena a partir de la 4ta posición de los nombres. Si no
            // contiene 4 o más caracteres mostrar "el apellido no contiene 4 caracteres o más".

            if (nom2.Length > 4)
            {
                Console.WriteLine("\nSub cadena: " + nom2.Substring(4));
            }
            else Console.WriteLine("No hay al menos 4 caracteres");

            // Convertir nombres en arreglo e imprimirlo verticalmente.

            char[] nom = nom1.ToCharArray();
            for (int i = 0; i < nom.Length; i++) 
            {
                Console.WriteLine(nom[i]);
            }

            // Imprimir el nombre en reversa.
            Console.WriteLine("Inversa nombre 1:");
            for (int i = nom.Length -1; i >= 0; i--)
            {
                Console.WriteLine(nom[i]);
            }

            // Imprimir los caracteres del nombre ordenado alfabéticamente.
            Console.BackgroundColor = ConsoleColor.Green;
            Array.Sort(nom);
            string n = new string(nom);
            Console.WriteLine("\nOrdenando: "+n);

            Console.ResetColor();
            

            Console.ReadKey();
        }
    }
}
