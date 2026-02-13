using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque4
{
    public class Ejercicio26
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while(!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 26: Frecuencia de elementos ===");

                int[] numeros = new int[20];
            int[] frecuencia = new int[11]; // uso 11 para usar índices 1-10

            Random random = new Random();// declara la variable que genera los numeros

            Console.WriteLine("Números generados:");
            for (int i = 0; i < 20; i++)
            {
                numeros[i] = random.Next(1, 11); // 1 al 10
                Console.Write(numeros[i] + " ");

                frecuencia[numeros[i]]++;
            }

            Console.WriteLine("\nFrecuencia de cada número:");

            int masFrecuente = 1;
            int menosFrecuente = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: {frecuencia[i]} veces");

                if (frecuencia[i] > frecuencia[masFrecuente])// evalua cual es el mas frecuente dentro del arreglo
                    masFrecuente = i;

                if (frecuencia[i] < frecuencia[menosFrecuente])// evalua el menos frecuente
                    menosFrecuente = i;
            }

            Console.WriteLine($"\nMás frecuente: {masFrecuente} ({frecuencia[masFrecuente]} veces)");
            Console.WriteLine($"Menos frecuente: {menosFrecuente} ({frecuencia[menosFrecuente]} veces)");

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