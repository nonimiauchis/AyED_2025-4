using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Para poder cobrar la beca JuanPedro se debe cumplir con alguna de las siguientes condiciones... 
            1) ser mayor de 19 años y tener unos ingresos iguales o inferiores a $100.000 mensuales
            2) ser menor de 19 y no poseer ingresos mensuales
            3) tener 19 años y poseer ingresos hasta $50.000 mensuales

            Escribir un programa que pregunte al usuario su edad y sus ingresos mensuales y muestre por pantalla 
            si el usuario puede cobrar o no.*/

            Console.WriteLine("Decime tu edad.");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Decime tu ingreso mensual.");
            int ingreso = int.Parse(Console.ReadLine());

            if (edad < 19 && ingreso == 0 || edad == 19 && ingreso <= 50000 || edad > 19 && ingreso <= 100000 )
            {
                Console.WriteLine("Cumplís con los requisitos para la beca wujuuuuuuuuuu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No cumplís con los requisitos para la beca buuuuuuu");
                Console.ReadLine();
            }
        }
    }
}
