using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio21
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 21: Patrón de asteriscos ===");

                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Triangulo invertido");
                Console.WriteLine("3. Rombo");
                Console.WriteLine("4. Cuadrado hueco");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 5)
                {
                    salir = true;
                    break;
                }

                Console.WriteLine("Ingrese el tamaño:");
                int tamaño = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        for (int i = 1; i <= tamaño; i++)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        for (int i = tamaño; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        for (int i = 1; i <= tamaño; i++)
                        {
                            for (int j = tamaño; j > i; j--)
                                Console.Write(" ");

                            for (int k = 1; k <= (2 * i - 1); k++)
                                Console.Write("*");

                            Console.WriteLine();
                        }

                        for (int i = tamaño - 1; i >= 1; i--)
                        {
                            for (int j = tamaño; j > i; j--)
                                Console.Write(" ");

                            for (int k = 1; k <= (2 * i - 1); k++)
                                Console.Write("*");

                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        for (int i = 1; i <= tamaño; i++)
                        {
                            for (int j = 1; j <= tamaño; j++)
                            {
                                if (i == 1 || i == tamaño || j == 1 || j == tamaño)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    break;
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