using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al usuario un número entero y muestre por pantalla si es par o impar.

              Y... ¿Si es 0?*/

            Console.WriteLine("Decime un número entero y te digo si es par o impar");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Tu número es 0, creo q es par, qsy jdjfjsdfjdjjejejje");
                Console.ReadLine();
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("Tu número es par.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tu número es impar.");
                Console.ReadLine();
            }
        }
    }
}
