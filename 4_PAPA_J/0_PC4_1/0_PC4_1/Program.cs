using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Utilizando variable tipo string definir un programa 
             * que almacene en una variable una cadena que sea "Hola mundo" e imprimirla
             
             Caso 1 (menos eficiente, usa mas lineas de codigo*/

            string mgustaelpoio;
            mgustaelpoio = "Hola Mundo";

            Console.WriteLine(mgustaelpoio);
            Console.ReadLine();

            /* Caso 2 (mas eficiente, usa menos lineas de codigo) */

            string mgustaelpollo = "Hola Mundo";

            Console.WriteLine(mgustaelpollo);
            Console.ReadLine();
        }
    }
}