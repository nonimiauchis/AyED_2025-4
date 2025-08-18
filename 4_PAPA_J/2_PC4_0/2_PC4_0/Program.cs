using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC4_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar la cantidad
             *  de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular el promedio de
             *   comida que necesitará por invitado. El programa solicitará al usuario que ingrese la cantidad de
             *    invitados y luego pedirá la cantidad de comida que cada invitado consume, asegurándose de que los 
             *    valores ingresados estén dentro del rango permitido (de 1 a 100). Una vez que se hayan ingresado todos
             *    los datos, el programa calculará el promedio de comida por invitado y lo mostrará en pantalla. */

            int prom = 0;

            Console.WriteLine("Cuantos invitados van a la fiesta?");
            int cantinv = int.Parse(Console.ReadLine());
            int[] inv = new int[cantinv];
            bool bien = true;
            for (int i = 0; i < cantinv; i++)
            {
                Console.WriteLine("Cuanto come el invitado " + (i + 1) + ": ");
                inv[i] = int.Parse(Console.ReadLine());
                if (inv[i] > 100)
                {
                    Console.WriteLine("Error");
                    bien = false;
                    break;

                }
                prom = prom + inv[i];
            }
            prom = prom / cantinv;
            if (bien)
            {
                Console.WriteLine("El promedio de comida por invitado es de " + prom);
            }
            Console.ReadLine();
        }
    }
}
