using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque4
{
    public class Ejercicio23
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 23: Estadisticas de clasificaciones ===");

                Console.Write("Ingrese la cantidad de calificaciones: ");
            int N = int.Parse(Console.ReadLine());

            double[] calificaciones = new double[N];
            double suma = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese la calificacion N.{i + 1}: ");
                calificaciones[i] = double.Parse(Console.ReadLine());
                suma += calificaciones[i];

                if (calificaciones[i] > max) //evalua la calificacion maxima
                    max = calificaciones[i];
                if (calificaciones[i] < min) //la minima
                    min = calificaciones[i];
                if (calificaciones[i] >= 65)//y los aprobados o reprobados
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / N;

            double sumaCuadrados = 0;
            for (int i = 0; i < N; i++)
            {
                sumaCuadrados += Math.Pow(calificaciones[i] - promedio, 2); // eleva al cuadrado
            }
            double desviacion = Math.Sqrt(sumaCuadrados / N); // usa la raiz para la desviacion estandar

            Console.WriteLine("=== Resultados ===");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Calificación máxima: {max}");
            Console.WriteLine($"Calificación mínima: {min}");
            Console.WriteLine($"Cantidad de aprobados: {aprobados}");
            Console.WriteLine($"Cantidad de reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {desviacion:F2}");

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