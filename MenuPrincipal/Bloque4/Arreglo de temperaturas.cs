using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque4
{
    public class Ejercicio27
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while(!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 27: Arreglo de temperaturas ===");

                double[] temperaturas = new double[7];
                double suma = 0;

                Console.WriteLine("=== Registro de temperaturas (7 días) ===");

                for (int i = 0; i < 7; i++)// Ingreso de temperaturas
                {
                    Console.Write($"Ingrese temperatura del día {i + 1}: ");
                    temperaturas[i] = double.Parse(Console.ReadLine());
                    suma += temperaturas[i];
                }

                double promedio = suma / 7;// promedio semanal

                int diasSobrePromedio = 0;// estas variables son de ayuda para evaluar cada caso
                int diaMasCaluroso = 0;
                int diaMasFrio = 0;

                for (int i = 0; i < 7; i++)
                {
                    if (temperaturas[i] > promedio)
                        diasSobrePromedio++;

                    if (temperaturas[i] > temperaturas[diaMasCaluroso])
                        diaMasCaluroso = i;

                    if (temperaturas[i] < temperaturas[diaMasFrio])
                        diaMasFrio = i;
                }

                Console.WriteLine("\n=== Resultados ===");
                Console.WriteLine($"Promedio semanal: {promedio:F2}");
                Console.WriteLine($"Días sobre el promedio: {diasSobrePromedio}");
                Console.WriteLine($"Día más caluroso: Día {diaMasCaluroso + 1} ({temperaturas[diaMasCaluroso]}°)");
                Console.WriteLine($"Día más frío: Día {diaMasFrio + 1} ({temperaturas[diaMasFrio]}°)");

                Console.WriteLine("\nVariación entre días consecutivos:");
                for (int i = 0; i < 6; i++)
                {
                    double variacion = temperaturas[i + 1] - temperaturas[i];
                    Console.WriteLine($"Día {i + 1} a Día {i + 2}: {variacion:+0.00;-0.00;0.00}");
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