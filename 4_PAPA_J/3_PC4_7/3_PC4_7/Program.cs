using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_7
{
    class Program
    {
        static void Main()
        {
            string[] nombres = new string[20];
            string[] sagas = new string[20];
            int[] fuerzas = new int[20];
            int[] defensas = new int[20];
            bool[] heroes = new bool[20];
            int cant = 0;

            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("\nBienvenido a Borderlands Multiverse Manager, crea tu patrulla de cazadores");
                Console.WriteLine("\n1. Nuevo");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Nombre: ");
                    nombres[cant] = Console.ReadLine();
                    Console.WriteLine("Saga: ");
                    sagas[cant] = Console.ReadLine();
                    Console.WriteLine("Fuerza: ");
                    fuerzas[cant] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Defensa: ");
                    defensas[cant] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Es heroe (s/n): ");
                    heroes[cant] = Console.ReadLine() == "s";
                    cant++;
                }

                if (opcion == 2)
                {
                    Console.WriteLine("Nombre a buscar: ");
                    string n = Console.ReadLine();
                    for (int i = 0; i < cant; i++)
                        if (nombres[i] == n)
                            Console.WriteLine(nombres[i] + " " + sagas[i] + " F:" + fuerzas[i] + " D:" + defensas[i] + " Heroe:" + heroes[i]);
                }

                if (opcion == 3)
                {
                    Console.WriteLine("Nombre a modificar: ");
                    string n = Console.ReadLine();
                    for (int i = 0; i < cant; i++)
                        if (nombres[i] == n)
                        {
                            Console.WriteLine("Nueva fuerza: ");
                            fuerzas[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nueva defensa: ");
                            defensas[i] = int.Parse(Console.ReadLine());
                        }
                }

                if (opcion == 4)
                {
                    Console.Write("Nombre a eliminar: ");
                    string n = Console.ReadLine();
                    for (int i = 0; i < cant; i++)
                        if (nombres[i] == n)
                        {
                            for (int j = i; j < cant - 1; j++)
                            {
                                nombres[j] = nombres[j + 1];
                                sagas[j] = sagas[j + 1];
                                fuerzas[j] = fuerzas[j + 1];
                                defensas[j] = defensas[j + 1];
                                heroes[j] = heroes[j + 1];
                            }
                            cant--;
                        }
                }

                if (opcion == 5)
                {
                    // ordenar por nombre simple
                    for (int i = 0; i < cant - 1; i++)
                        for (int j = i + 1; j < cant; j++)
                            if (nombres[i].CompareTo(nombres[j]) > 0)
                            {
                                string tmpNom = nombres[i]; nombres[i] = nombres[j]; nombres[j] = tmpNom;
                                string tmpSag = sagas[i]; sagas[i] = sagas[j]; sagas[j] = tmpSag;
                                int tmpF = fuerzas[i]; fuerzas[i] = fuerzas[j]; fuerzas[j] = tmpF;
                                int tmpD = defensas[i]; defensas[i] = defensas[j]; defensas[j] = tmpD;
                                bool tmpH = heroes[i]; heroes[i] = heroes[j]; heroes[j] = tmpH;
                            }

                    for (int i = 0; i < cant; i++)
                        Console.WriteLine(nombres[i] + " " + sagas[i] + " F:" + fuerzas[i] + " D:" + defensas[i] + " Heroe:" + heroes[i]);
                }
            }
        }
    }
}
