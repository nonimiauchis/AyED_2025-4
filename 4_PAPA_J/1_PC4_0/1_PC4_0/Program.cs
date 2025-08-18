using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC4_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pregunte al usuario
            su edad y muestre por pantalla si es mayor de edad o no.*/

            Console.WriteLine("¿Cuántos años tenés?");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Sos menor de edad, por lo tanto, no pasas. Sali lacra.");
                Console.ReadLine();
            }
            else
                Console.WriteLine("sos mayor de edad, por lo tanto, pasa cumpa. Pasala nashe.");

            Console.ReadLine();
        }
    }
}
