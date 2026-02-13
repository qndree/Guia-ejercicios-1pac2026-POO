using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    class Ejercicio02
    {
        public static void Ejecutar()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n=== Ejercicio 2: Menu de conversion de temperaturas ===");
            
            Console.WriteLine("1 - Celsius a Fahrenheit");
            Console.WriteLine("2 - Fahrenheit a Celsius");
            Console.WriteLine("3 - Celsius a Kelvin");
            Console.WriteLine("4 - Kelvin a Celsius");
            Console.WriteLine("5 - Fahrenheit a Kelvin");
            Console.WriteLine("6 - Kelvin a Fahrenheit");
            Console.WriteLine("Seleccione que temperatura desea convertir:");
            Console.WriteLine("0 - Volver al menú principal");

            string opcion = Console.ReadLine();
            // Mediante un switch hice el menu para seleccionar que desea convertir el usuario usando las formulas basicas de conversion de temperaturas
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la temperatura en Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit:F2}");
                    break;
                case "2":
                    Console.Write("Ingrese la temperatura en Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Temperatura en Celsius: {celsius:F2}");
                    break;
                case "3":
                    Console.Write("Ingrese la temperatura en Celsius: ");
                    celsius = double.Parse(Console.ReadLine());
                    double kelvin = celsius + 273.15;
                    Console.WriteLine($"Temperatura en Kelvin: {kelvin:F2}");
                    break;
                case "4":
                    Console.Write("Ingrese la temperatura en Kelvin: ");
                    kelvin = double.Parse(Console.ReadLine());
                    celsius = kelvin - 273.15;
                    Console.WriteLine($"Temperatura en Celsius: {celsius:F2}");
                    break;
                case "5":
                    Console.Write("Ingrese la temperatura en Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"Temperatura en Kelvin: {kelvin:F2}");
                    break;
                case "6":
                    Console.Write("Ingrese la temperatura en Kelvin: ");
                    kelvin = double.Parse(Console.ReadLine());
                    fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit:F2}");
                    break;
                case "0":
                    return;    
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
}
    }
}