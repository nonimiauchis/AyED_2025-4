using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desarrollar un codigo en le que almacenemos el nombre en una
             *  variable "nombre" y la edad en la variable "edad".
             *   Finalmente debe saludar "Hola NOMBRE, tu edad es EDAD"
             *   El valor de "nombre" y "edad" debe ser ingresado
             *   por el usuario 
             */

            Console.WriteLine("¿Cual es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿Cual es tu edad?");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola " + nombre + ", tu edad es " + edad);
            Console.ReadLine();
        }
    }
}