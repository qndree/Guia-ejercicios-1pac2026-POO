using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio08
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 8: Calculo de salario semanal ===");

                Console.WriteLine("Ingrese el número de horas trabajadas en la semana: ");
                double horasTrabajadas = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tarifa por hora: ");
                double tarifaPorHora = double.Parse(Console.ReadLine());
                double salarioSemanal = horasTrabajadas * tarifaPorHora;
                Console.WriteLine($"El salario semanal es: {salarioSemanal:F2}");
                // si el trabajador trabajo mas de 44 horas se le otorgara un extra de 150% a su salario semanal
                if (horasTrabajadas > 44)
                {
                    double horasExtra = horasTrabajadas - 44;
                    double pagoHorasExtra = horasExtra * tarifaPorHora * 1.5;
                    salarioSemanal += pagoHorasExtra;
                    Console.WriteLine($"Se pagaron {horasExtra} horas extra, con un pago adicional de: {pagoHorasExtra:F2}");
                    Console.WriteLine($"El salario semanal total con horas extra es: {salarioSemanal:F2}");    
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