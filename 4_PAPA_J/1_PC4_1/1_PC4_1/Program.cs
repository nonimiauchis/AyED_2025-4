using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que almacene la cadena de caracteres contraseña en una variable, pregunte al
             *  usuario por la contraseña e imprima por pantalla si la contraseña introducida por el usuario
             *  coincide con la guardada en la variable sin tener en cuenta mayúsculas y minúsculas.*/

            string contra = "HOLAMUNDO";

            Console.WriteLine("Contraseña: holamundo. Ingresá la contraseña: ");
            string contrain = Console.ReadLine();
            contrain = contrain.ToUpper();

            if (contrain == contra)
            {
                Console.WriteLine("Contraseña correcta.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
                Console.ReadLine();
            }
        }
    }
}
