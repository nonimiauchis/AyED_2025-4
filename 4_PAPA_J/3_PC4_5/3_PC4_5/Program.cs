using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_5
{
    class Program
    {
        static int Atacar(int atk, int hpEnemigo)
        {
            hpEnemigo -= atk;
            if (hpEnemigo < 0)
                hpEnemigo = 0;
            return hpEnemigo;
        }

        static int Curar(int hpHornet, int hpMaxHornet)
        {
            hpHornet += 5;
            if (hpHornet > hpMaxHornet)
                hpHornet = hpMaxHornet;
            return hpHornet;
        }

        static void MostrarEstado(int hpHornet, int hpEnemigo)
        {
            Console.WriteLine($"Hornet HP: {hpHornet} | Enemigo HP: {hpEnemigo}");
        }
        static void Main()
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;
            Console.WriteLine("=== Hollow Knight: Simulador básico ===");

            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.Write("\nAcción (atacar/curar/salir): ");
                string accion = Console.ReadLine();

                if (accion == "atacar")
                {
                    hpEnemigo = Atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = Curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción no válida.");
                }

                // Enemigo ataca automáticamente
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
                }
            }

            Console.WriteLine("\n=== Resultado ===");
            if (hpHornet <= 0)
            {
                Console.WriteLine("Hornet ha caído...");
                Console.ReadLine();
            }
            else if (hpEnemigo <= 0)
            {
                Console.WriteLine("¡Hornet ganó!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Batalla interrumpida.");
                Console.ReadLine();
            }
        }
    }
}