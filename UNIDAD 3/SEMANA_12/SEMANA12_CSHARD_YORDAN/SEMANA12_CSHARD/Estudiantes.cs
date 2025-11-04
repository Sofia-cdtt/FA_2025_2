using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12_CSHARD
{
    internal class Estudiantes
    {
        // Estas variables siempre debe ser global
        // para que puedas usarlas en otros métodos
        byte[] edades = new byte[0]; //para optimizar recursos
        int pos = 0;

        public void Registrar() 
        {
            byte edad;
            
            while (true)
            {
                Console.Write("\nIngrese edad: ");
                if (byte.TryParse(Console.ReadLine(), out edad) & edad >= 14 && edad <= 120) break; 
                else Console.WriteLine("¡Ingrese una edad correcta!\n");
            }

            Array.Resize(ref edades, edades.Length + 1);
            edades[pos] = edad;
            pos++;

            Console.WriteLine("\nEdad registrada correctamente. ");
        }

        public void Mostrar() 
        {
            Console.WriteLine("\nPOS\tEDAD");
            
            for (int i = 0; i < edades.Length; i++) 
            {
                Console.WriteLine(i + "\t" + edades[i]);
            }
        }

        public void Eliminar() 
        {
            int Índice = -1;
            Console.Write("\nIngrese la edad a eliminar: ");
            byte edad = byte.Parse(Console.ReadLine());

            for (int i = 0; i < edades.Length; i++) 
            {
                if (edades[i] == edad)
                    Índice = i;
            }

            if (Índice != -1)
            {
                for (int j = Índice; j < edades.Length-1; j++)
                    edades[j] = edades[j + 1];

                Array.Resize(ref edades, edades.Length - 1);
                pos--;
                Console.WriteLine("\nEdad eliminada correctamente");
            }
            else Console.WriteLine("\nNo se puede eliminar porque no existe.");
        }

        public void Ordenar() 
        {
            for (int i = 0; i < edades.Length - 1; i++) 
            {
                for (int j = 0; j < edades.Length - 1 - i; j++) 
                {
                    if (edades[j] < edades[j + 1]) 
                    {
                        byte temp = edades[j];
                        edades[j] = edades[j + 1];
                        edades[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSe ordeno correctamente. ");
        }
    }
}
