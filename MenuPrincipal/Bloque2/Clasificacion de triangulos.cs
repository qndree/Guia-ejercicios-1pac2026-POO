using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio09
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 9: Clasificación de triángulos ===");
                
                Console.WriteLine("Ingrese el primer lado del triángulo:");
                double lado1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo lado del triángulo:");
                double lado2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer lado del triángulo:");
                double lado3 = Convert.ToDouble(Console.ReadLine());
                // En este if evaluo si los lados forman un triangulo valido, para eso utilizo la propiedad de que la suma de dos lados debe ser mayor al tercer lado
                if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                {
                    Console.WriteLine("Los lados forman un triángulo válido.");

                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        Console.WriteLine("El triángulo es equilátero.");
                    }
                    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("El triángulo es isósceles.");
                    }
                    else
                    {
                        Console.WriteLine("El triángulo es escaleno.");
                    }
                    // Encontre una logica para determinar el tipo de triangulo por sus angulos, utilizando la formula del coseno para encontrar los angulos y luego compararlos con 90 grados
                    double a = Math.Acos((Math.Pow(lado2, 2) + Math.Pow(lado3, 2) - Math.Pow(lado1, 2)) / (2 * lado2 * lado3));
                    double b = Math.Acos((Math.Pow(lado1, 2) + Math.Pow(lado3, 2) - Math.Pow(lado2, 2)) / (2 * lado1 * lado3));
                    double c = Math.Acos((Math.Pow(lado1, 2) + Math.Pow(lado2, 2) - Math.Pow(lado3, 2)) / (2 * lado1 * lado2));

                    if (a == Math.PI / 2 || b == Math.PI / 2 || c == Math.PI / 2)
                    {
                        Console.WriteLine("El triángulo es rectángulo.");
                    }
                    else if (a < Math.PI / 2 && b < Math.PI / 2 && c < Math.PI / 2)
                    {
                        Console.WriteLine("El triángulo es acutángulo.");
                    }
                    else
                    {
                        Console.WriteLine("El triángulo es obtusángulo.");
                    }
                }
                else
                {
                    Console.WriteLine("Los lados no forman un triángulo válido.");
                }
                Console.WriteLine("\nDesea repetir el programa? (si/no)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                    salir = false;
                else if (respuesta == "no")
                    salir = true;
                while (respuesta != "si" && respuesta != "no")

                if (respuesta != "si" && respuesta != "no")
                {
                    Console.WriteLine("Respuesta no válida, repita su peticion");
                    respuesta = Console.ReadLine().ToLower();
                }
            }
        }
    }
}