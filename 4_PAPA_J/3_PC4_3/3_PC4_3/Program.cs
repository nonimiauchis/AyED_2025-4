using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC4_3
{
    class Program
    {
        const int max_encargos = 25;
        static string[,] encargos = new string[max_encargos, 5];
        static int cantidad_registrados = 0;

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": CrearEncargo(); break;
                    case "2": MostrarEncargos(); break;
                    case "3": AsignarCamion(); break;
                    case "4": MostrarEncargosAsignados(); break;
                    case "5": PromedioGananciaPorSede(); break;
                    case "6": EncargoMayorDistancia(); break;
                    case "7": FiltrarPorCodigoCamion(); break;
                    case "8": continuar = false; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\n==== Argentinian Simulator ====");
            Console.WriteLine("1. Crear nuevo encargo");
            Console.WriteLine("2. Mostrar todos los encargos");
            Console.WriteLine("3. Asignar camión a encargo");
            Console.WriteLine("4. Mostrar encargos asignados");
            Console.WriteLine("5. Promedio de ganancia por sede");
            Console.WriteLine("6. Encargo con mayor distancia");
            Console.WriteLine("7. Filtrar encargos por código de camión");
            Console.WriteLine("8. Salir");
            Console.Write("Ingrese una opción: ");
        }

        static void CrearEncargo()
        {
            if (cantidad_registrados >= max_encargos)
            {
                Console.WriteLine("No se pueden ingresar más encargos.");
                return;
            }

            int distancia = LeerEnteroPositivo("Ingrese la distancia en km del encargo: ");
            string sede = LeerSede();
            Console.Write("Ingrese la ganancia esperada ($): ");
            string ganancia = Console.ReadLine();

            encargos[cantidad_registrados, 0] = ""; // Cod camion
            encargos[cantidad_registrados, 1] = distancia.ToString();
            encargos[cantidad_registrados, 2] = sede;
            encargos[cantidad_registrados, 3] = ganancia;
            encargos[cantidad_registrados, 4] = "0"; // Asignado

            cantidad_registrados++;
            Console.WriteLine("Encargo registrado exitosamente.");
        }

        static void MostrarEncargos()
        {
            Console.WriteLine("\n| Fila | Codcamion | Distancia | Sede | Ganancia | Asignado |");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                Console.WriteLine($"| {i + 1} | {encargos[i, 0]} | {encargos[i, 1]} | {encargos[i, 2]} | {encargos[i, 3]} | {encargos[i, 4]} |");
            }
        }

        static void AsignarCamion()
        {
            Console.WriteLine("\nEncargos no asignados:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"{i + 1}. Distancia: {encargos[i, 1]} km | Sede: {encargos[i, 2]} | Ganancia: {encargos[i, 3]}");
                }
            }

            int index = LeerEnteroPositivo("Seleccione el número del encargo: ") - 1;
            if (encargos[index, 4] == "1")
            {
                Console.WriteLine("Ese encargo ya tiene camión asignado.");
                return;
            }

            Console.Write("Ingrese el código del camión: ");
            string codcamion = Console.ReadLine();
            encargos[index, 0] = codcamion;
            encargos[index, 4] = "1";

            Console.WriteLine("Camión asignado correctamente.");
        }

        static void MostrarEncargosAsignados()
        {
            Console.WriteLine("\nEncargos con camión asignado:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 4] == "1")
                {
                    Console.WriteLine($"Encargo {i + 1}: Camión {encargos[i, 0]} | Distancia {encargos[i, 1]} km | Sede {encargos[i, 2]} | Ganancia {encargos[i, 3]}");
                }
            }
        }

        static void PromedioGananciaPorSede()
        {
            double[] suma = new double[3];
            int[] cantidad = new int[3];
            string[] sedes = { "BSAS", "BB", "MDQ" };

            for (int i = 0; i < cantidad_registrados; i++)
            {
                int sedeIndex = int.Parse(encargos[i, 2]) - 1;
                suma[sedeIndex] += double.Parse(encargos[i, 3]);
                cantidad[sedeIndex]++;
            }

            for (int i = 0; i < 3; i++)
            {
                double promedio = (cantidad[i] > 0) ? suma[i] / cantidad[i] : 0;
                Console.WriteLine($"Promedio {sedes[i]}: ${promedio}");
            }
        }

        static void EncargoMayorDistancia()
        {
            int maxDist = 0;
            for (int i = 0; i < cantidad_registrados; i++)
            {
                int dist = int.Parse(encargos[i, 1]);
                if (dist > maxDist) maxDist = dist;
            }

            Console.WriteLine("Encargos con la mayor distancia:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (int.Parse(encargos[i, 1]) == maxDist)
                {
                    Console.WriteLine($"Encargo {i + 1}: {maxDist} km | Ganancia ${encargos[i, 3]}");
                }
            }
        }

        static void FiltrarPorCodigoCamion()
        {
            Console.Write("Ingrese el código de camión: ");
            string codigo = Console.ReadLine();

            Console.WriteLine($"Encargos del camión {codigo}:");
            for (int i = 0; i < cantidad_registrados; i++)
            {
                if (encargos[i, 0] == codigo)
                {
                    Console.WriteLine($"Encargo {i + 1}: Distancia {encargos[i, 1]} km | Sede {encargos[i, 2]} | Ganancia {encargos[i, 3]}");
                }
            }
        }

        // Funciones auxiliares
        static int LeerEnteroPositivo(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
            } while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0);
            return valor;
        }

        static string LeerSede()
        {
            string sede;
            do
            {
                Console.Write("Ingrese sede (1=BSAS, 2=BB, 3=MDQ): ");
                sede = Console.ReadLine();
            } while (sede != "1" && sede != "2" && sede != "3");
            return sede;
        }
    }
}

