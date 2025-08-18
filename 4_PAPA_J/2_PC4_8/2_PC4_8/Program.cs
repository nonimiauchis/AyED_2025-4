using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla

            n y m son datos que ingresa el usuario*/

            Console.WriteLine("Decime el numero de filas de tu matriz.");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Decime el numero de columnas de tu matriz.");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
