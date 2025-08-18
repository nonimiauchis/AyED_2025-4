using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Llenar una matriz de n×m con valores aleatorios entre un rango dado (por ejemplo, 1 a 100).*/

            Random rand = new Random();

            Console.WriteLine("Decime el numero de filas de tu matriz.");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Decime el numero de columnas de tu matriz.");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    Console.WriteLine(matriz[i, j] + "\t");
                }
            }

            Console.ReadLine();
        }
    }
}
