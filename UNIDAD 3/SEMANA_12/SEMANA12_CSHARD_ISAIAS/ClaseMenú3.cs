using System;

namespace SEMANA12_CSHARD_ISAIAS
{
    public class ClaseMenú3
    {
        public static void ReemplazarPosición(int Posición, int ele) 
        {
            //EJERCICIO 3
            
            // Cambiamos el tamaño del arreglo para que acepte
            // un valor más

            Array.Resize(ref Ejercicio3.valorNum, Ejercicio3.valorNum.Length + 1);

            for (int i = (Ejercicio3.valorNum.Length - 1); i >= 0; i--)
            {
                // Consultamos si el i (index) es igual a la (Posición - 1)
                if (i == (Posición - 1))
                {
                    // 
                    Ejercicio3.valorNum[i] = ele;
                    break; //Terminar con la estructura
                }
                else 
                {
                    Ejercicio3.valorNum[i] = Ejercicio3.valorNum[i - 1];
                }
                    
            }
            
        }
    }
}
