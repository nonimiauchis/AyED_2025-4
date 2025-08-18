using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El Rayo McQueen está compitiendo en una carrera de alta velocidad.
             *  Necesita un programa en C# que le ayude a registrar los tiempos de cada vuelta
             *   y calcular algunas estadísticas importantes. 
            El programa debe cumplir el siguiente orden:
            Permitir al Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos.
            Utiliza un array para almacenar estos tiempos.
            Calcular y mostrar en pantalla el tiempo total de la carrera.
            Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
            Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor
            tiempo registrado.
            El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen
            y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.

            (Opcional: los tiempos se pueden ingresar automáticamente con un for y un Random...
            recordar nombreRandom.Next(10, 500) ).*/

            Random rand = new Random();
            int prom = 0;
            int total = 0;
            int[] vueltas = new int[5];
            for (int i = 0; i < vueltas.Length; i++)
            {
                int segs = rand.Next(90, 121);
                vueltas[i] = segs;
                total = total + vueltas[i];
            }

            for (int i = 0; i < vueltas.Length; i++)
            {
                Console.WriteLine("Tiempo de vuelta " + (i + 1) + ": " + vueltas[i]);
            }
            int menor = vueltas[0];
            for (int i = 0; i < vueltas.Length; i++)
            {
                if (menor > vueltas[i])
                {
                    menor = vueltas[i];
                }
            }
            prom = total / vueltas.Length;
            Console.WriteLine("El tiempo total de la carrera fue: " + total);
            Console.WriteLine("El promedio del tiempo de las vueltas es: " + prom);
            Console.WriteLine("La vuelta con mejor tiempo es: " + menor);
            Console.ReadLine();
        }
    }
}
