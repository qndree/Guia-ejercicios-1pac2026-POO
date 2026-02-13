using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque4
{
    public class Ejercicio24
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 24: Busqueda y ordenamiento ===");

                int[] numeros = new int[10];

                Console.WriteLine("Ingrese 10 números enteros:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Número N.{i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese un número a buscar:");
                int buscar = int.Parse(Console.ReadLine());
                bool encontrado = false;
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] == buscar)
                    {
                        Console.WriteLine($"Número encontrado en la posición {i + 1}");
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                    Console.WriteLine("Número no encontrado.");

                int mayor = int.MinValue;
                int segundoMayor = int.MinValue;
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] > mayor)
                    {
                        segundoMayor = mayor;
                        mayor = numeros[i];
                    }
                    else if (numeros[i] > segundoMayor && numeros[i] != mayor)
                    {
                        segundoMayor = numeros[i];
                    }
                }
                Console.WriteLine($"El segundo mayor es: {segundoMayor}");

                for (int i = 0; i < 10 - 1; i++)
                {
                    for (int j = 0; j < 10 - i - 1; j++)
                    {
                        if (numeros[j] > numeros[j + 1]) // aca se hace el ordenamiento burbuja
                        {
                            int temp = numeros[j];
                            numeros[j] = numeros[j + 1];
                            numeros[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Arreglo ordenado ascendentemente:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(numeros[i] + " ");
                }
        
                Console.WriteLine("Elementos en posiciones pares:");

                for (int i = 0; i < 10; i += 2)
                {
                    Console.WriteLine($"Posición {i}: {numeros[i]}");
                }
                Console.WriteLine("\nDesea repetir el programa? (si/no)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                    salir = false;
                else if (respuesta == "no")
                    salir = true;
                while (respuesta != "si" && respuesta != "no")
                {
                if (respuesta != "si" && respuesta != "no")
                {
                    Console.WriteLine("Respuesta no válida, repita su peticion");
                    respuesta = Console.ReadLine().ToLower();
                }
                }
            }
        }
    }
}