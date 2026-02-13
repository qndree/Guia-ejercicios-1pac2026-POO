using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque5
{
    public class Ejercicio28
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while(!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 28: Matriz de notas por parcial ===");

                Console.Write("Ingrese la cantidad de estudiantes: ");
                int cantidadEstudiantes = int.Parse(Console.ReadLine());

                double[,] notas = new double[cantidadEstudiantes, 3];

            
                for (int i = 0; i < cantidadEstudiantes; i++)// ingreso de las notas
                {
                    Console.WriteLine($"\nEstudiante {i + 1}:");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Nota del parcial {j + 1}: ");
                        notas[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\n=== Resultados ===");

                double mejorPromedio = 0;
                int mejorEstudiante = 0;

                for (int i = 0; i < cantidadEstudiantes; i++)
                {
                    double suma = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        suma += notas[i, j];
                    }

                    double promedioEstudiante = suma / 3;
                    Console.WriteLine($"Promedio estudiante {i + 1}: {promedioEstudiante:F2}");

                    if (promedioEstudiante > mejorPromedio)
                    {
                        mejorPromedio = promedioEstudiante;
                        mejorEstudiante = i;
                    }
                }

                double peorPromedioParcial = double.MaxValue;
                int parcialMasDificil = 0;

                for (int j = 0; j < 3; j++)
                {
                    double suma = 0;

                    for (int i = 0; i < cantidadEstudiantes; i++)
                    {
                        suma += notas[i, j];
                    }

                    double promedioParcial = suma / cantidadEstudiantes;
                    Console.WriteLine($"Promedio parcial {j + 1}: {promedioParcial:F2}");

                    if (promedioParcial < peorPromedioParcial)
                    {
                        peorPromedioParcial = promedioParcial;
                        parcialMasDificil = j;
                    }
                }

                Console.WriteLine($"\nEstudiante con mejor promedio: Estudiante {mejorEstudiante + 1} ({mejorPromedio:F2})");
                Console.WriteLine($"Parcial más difícil: Parcial {parcialMasDificil + 1} ({peorPromedioParcial:F2})");

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