using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_4._LEVEL4_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");

            Console.WriteLine("\nPresione Enter para salir...");
            Console.ReadLine();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsLower(c))
                {
                    result[i] = (c == 'z') ? 'a' : (char)(c + 1);
                }
                else if (char.IsUpper(c))
                {
                    result[i] = (c == 'Z') ? 'A' : (char)(c + 1);
                }
                else
                {
                    result[i] = c; 
                }
            }

            return new string(result);
        }
    }
}