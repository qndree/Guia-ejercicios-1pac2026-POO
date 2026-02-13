using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio15
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 15: Tabla de multiplicar extendida ===");

                Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nTabla de multiplicar del {numero}:");
                for (int i = 1; i <= 12; i++)// solo uso un for para mostrar la tabla de multiplicar 
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");// aca solo imprimo el resultado y de un solo hago la multiplicacion
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