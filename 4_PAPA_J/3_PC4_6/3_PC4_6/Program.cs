using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO ===");

            // mano
            string[] mano = GenerarMano();
            Console.WriteLine("Mano: " + string.Join(" ", mano));

            // tipo
            string tipo = Tipo(mano);
            Console.WriteLine("Tipo: " + tipo);

            // puntaje
            int basePts = Puntos(mano);
            Console.WriteLine("Puntaje base: " + basePts);

            // mult
            double mult = Multi(tipo);
            Console.WriteLine("Multiplicador: x" + mult);

            // total
            double total = basePts * mult;

            // jokers
            total = Jokers(total, true, true);

            Console.WriteLine("Total final: " + total);

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }

        static string[] GenerarMano()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "C", "D", "P", "T" };
            Random r = new Random();
            string[] m = new string[5];

            for (int i = 0; i < 5; i++)
            {
                m[i] = rangos[r.Next(rangos.Length)] + palos[r.Next(palos.Length)];
            }

            return m;
        }

        static string Tipo(string[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                int iguales = 1;
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (m[i][0] == m[j][0]) iguales++;
                }
                if (iguales == 4) return "Poker";
                if (iguales == 3) return "Trio";
                if (iguales == 2) return "Par";
            }
            return "Nada";
        }

        static int Puntos(string[] m)
        {
            int tot = 0;
            for (int i = 0; i < m.Length; i++)
            {
                char r = m[i][0];
                if (r == 'A') tot += 14;
                else if (r == 'K') tot += 13;
                else if (r == 'Q') tot += 12;
                else if (r == 'J') tot += 11;
                else if (r == 'T') tot += 10;
                else tot += int.Parse(r.ToString());
            }
            return tot;
        }

        static double Multi(string t)
        {
            if (t == "Par") return 1.5;
            if (t == "Trio") return 2.5;
            if (t == "Poker") return 4;
            return 1;
        }

        static double Jokers(double tot, bool x2, bool mas10)
        {
            if (x2) tot *= 2;
            if (mas10) tot += 10;
            return tot;
        }
    }
}