using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio17
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 17: Serie de Fibonacci ===");

                Console.WriteLine("\nIngrese un numero para mostrar su serie de Fibonacci: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nSerie de Fibonacci del {numero}:");
                int a = 0, b = 1;
                int c= 0;
                Console.WriteLine($"{a}");
                Console.WriteLine($"{b}");
                int acum = 0;// Variable para acumular la suma de la serie
                for (int i = 1; i <= numero; i++)
                {
                    c = a + b;
                    acum += b;
                    Console.WriteLine($"{c} ");
                    a = b;
                    b = c;
                }
                Console.WriteLine($"La Suma total de la serie es: {acum}");
                Console.WriteLine($"El promedio de la serie es: {acum / numero}");// aca de un solo saque el promedio ya que solo es dividir el total entre el numero que es la cantidad
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