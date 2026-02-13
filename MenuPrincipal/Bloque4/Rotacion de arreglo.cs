using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque4
{
    public class Ejercicio25
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Ejercicio 25: Rotacion de arreglo ===");

            Console.Write("Ingrese el tamaño del arreglo: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Elemento #{i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Rotación de Arreglo ===");
                MostrarArreglo(numeros);

                Console.WriteLine("\n1 - Rotar izquierda");
                Console.WriteLine("2 - Rotar derecha");
                Console.WriteLine("3 - Invertir arreglo");
                Console.WriteLine("0 - Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Cuantas posiciones?: ");
                        int posicionesIzquierda = int.Parse(Console.ReadLine());
                        numeros = RotarIzquierda(numeros, posicionesIzquierda);
                        break;

                    case 2:
                        Console.Write("Cuantas posiciones?: ");
                        int posicionesDerecha = int.Parse(Console.ReadLine());
                        numeros = RotarDerecha(numeros, posicionesDerecha);
                        break;

                    case 3:
                        Array.Reverse(numeros);
                        break;

                    case 0:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }

        static int[] RotarIzquierda(int[] arreglo, int posicionesIzquierda)
        {
            int tamaño = arreglo.Length;
            int[] nuevo = new int[tamaño];

            posicionesIzquierda = posicionesIzquierda % tamaño;

            for (int i = 0; i < tamaño; i++)
            {
                nuevo[i] = arreglo[(i + posicionesIzquierda) % tamaño];
            }

            return nuevo;// retorna el nuevo arreglo con las posiciones cambiadas segun la solicitud en cada caso
        }

        static int[] RotarDerecha(int[] arreglo, int posicionesDerecha)
        {
            int tamaño = arreglo.Length;
            int[] nuevo = new int[tamaño];

            posicionesDerecha = posicionesDerecha % tamaño;

            for (int i = 0; i < tamaño; i++)
            {
                nuevo[(i + posicionesDerecha) % tamaño] = arreglo[i];
            }

            return nuevo;
        }

        static void MostrarArreglo(int[] arreglo)
        {
            Console.WriteLine("Arreglo actual:");
            foreach (int numero in arreglo)
            {
                Console.Write($" {numero} ");
            }
        }
    }
}