using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio07
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 7: Conversión de unidades de almacenamiento ===");
                Console.WriteLine("Seleccione la conversión que desea realizar:");
                Console.WriteLine("1 - Bytes a Kilobytes");
                Console.WriteLine("2 - Kilobytes a Bytes");
                Console.WriteLine("3 - Kilobytes a Megabytes");
                Console.WriteLine("4 - Megabytes a Kilobytes");
                Console.WriteLine("5 - Megabytes a Gigabytes");
                Console.WriteLine("6 - Gigabytes a Megabytes");
                Console.WriteLine("7 - Gigabytes a Terabytes");
                Console.WriteLine("8 - Terabytes a Gigabytes");
                Console.WriteLine("0 - Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();
                // Parecido al de temperatura pero ahora con el sistema de almacenamiento
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la cantidad en Bytes: ");
                        double bytes = double.Parse(Console.ReadLine());
                        double kilobytes = bytes / 1024;
                        Console.WriteLine($"Cantidad en Kilobytes: {kilobytes:F2}");
                        break;
                    case "2":
                        Console.Write("Ingrese la cantidad en Kilobytes: ");
                        kilobytes = double.Parse(Console.ReadLine());
                        double Bytes = kilobytes * 1024;
                        Console.WriteLine($"Cantidad en Bytes: {Bytes:F2}");
                        break;
                    case "3":
                        Console.Write("Ingrese la cantidad en kilobytes: ");
                        double kilobytesinput = double.Parse(Console.ReadLine());
                        double Megabytes = kilobytesinput / 1024;
                        Console.WriteLine($"Cantidad en Megabytes: {Megabytes:F2}");
                        break;
                    case "4":
                        Console.Write("Ingrese la cantidad en Megabytes: ");
                        double megabytesinput = double.Parse(Console.ReadLine());
                        double kilobytes3 = megabytesinput * 1024;
                        Console.WriteLine($"Cantidad en Kilobytes: {kilobytes3:F2}");
                        break;
                    case "5":
                        Console.Write("Ingrese la cantidad en Megabytes: ");
                        double megabytes3 = double.Parse(Console.ReadLine());
                        double gigabytes = megabytes3 / 1024;
                        Console.WriteLine($"Cantidad en Gigabytes: {gigabytes:F2}");
                        break;
                    case "6":
                        Console.Write("Ingrese la cantidad en Gigabytes: ");    
                        double gigabytesinput = double.Parse(Console.ReadLine());
                        double megabytes4 = gigabytesinput * 1024;
                        Console.WriteLine($"Cantidad en Megabytes: {megabytes4:F2}");
                        break;
                    case "7":
                        Console.Write("Ingrese la cantidad en Gigabytes: ");    
                        double gigabytes3 = double.Parse(Console.ReadLine());
                        double terabytes = gigabytes3 / 1024;
                        Console.WriteLine($"Cantidad en Terabytes: {terabytes:F2}");
                        break;
                    case "8":
                        Console.Write("Ingrese la cantidad en Terabytes: ");    
                        double terabytesinput = double.Parse(Console.ReadLine());
                        double gigabytes4 = terabytesinput * 1024;
                        Console.WriteLine($"Cantidad en Gigabytes: {gigabytes4:F2}");
                        break;
                    case "0":
                        salir = true; break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
    }
}