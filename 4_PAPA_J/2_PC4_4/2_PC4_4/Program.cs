using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Durante el evento de ventas "Hot Sale", una tienda en línea desea conocer cuál fue el producto más caro y el más económico que se vendió durante el evento.
            El programa solicitará al usuario que ingrese la cantidad de productos vendidos durante el Hot Sale. Luego, pedirá al usuario que ingrese el precio de cada producto, uno por uno. Una vez ingresados todos los precios, el programa determinará cuál fue el precio más alto y cuál fue el precio más bajo. Finalmente, mostrará al usuario los precios más alto y más bajo registrados durante el evento.*/

            Console.Write("¿Cuántos productos vendieron? ");
            int cant = int.Parse(Console.ReadLine());
            int[] part = new int[cant];

            for (int i = 0; i < part.Length; i++)
            {
                Console.Write("¿Cuánto salió el producto " + (i + 1) + "? ");
                part[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < part.Length - 1; i++)
            {
                for (int j = 0; j < part.Length - 1 - i; j++)
                {
                    if (part[j] < part[j + 1])
                    {

                        int temp = part[j];
                        part[j] = part[j + 1];
                        part[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Precios ordenados de mayor a menor:");
            for (int i = 0; i < part.Length; i++)
            {
                Console.WriteLine("El producto " + (i + 1) + " salió " + part[i]);
            }

            Console.ReadLine();
        }
    }
}
