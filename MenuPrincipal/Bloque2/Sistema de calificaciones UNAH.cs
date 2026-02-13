using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        {
        bool salir = false;
        while(!salir)
        {
            Console.Clear();
            Console.WriteLine("\n=== Ejercicio 10: Sistema de calificaciones UNAH ===");
            Console.WriteLine("Ingrese la calificación del estudiante (0-100):");
            double calificacion = Convert.ToDouble(Console.ReadLine());
            // Estructura sencilla usando if para evaluar cada rango de calificaciones 
            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.WriteLine("Calificación: A");
                Console.WriteLine("Aprobo con excelente nota");
            }
            else if (calificacion >= 80 && calificacion < 90)
            {
                Console.WriteLine("Calificación: B");
                Console.WriteLine("Aprobo con buena nota");
            }
            else if (calificacion >= 70 && calificacion < 80)
            {
                Console.WriteLine("Calificación: C");
                Console.WriteLine("Aprobo por poco");
            }
            else if (calificacion >= 65 && calificacion < 70)
            {
                Console.WriteLine("Calificación: D");
                Console.WriteLine("Aprobo a duras penas");
            }
            else if (calificacion >= 0 && calificacion < 65)
            {
                Console.WriteLine("Calificación: F");
                Console.WriteLine("Reprobo mi bro");
            }
            else
            {
                Console.WriteLine("Calificación no válida. Ingrese un valor entre 0 y 100.");
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