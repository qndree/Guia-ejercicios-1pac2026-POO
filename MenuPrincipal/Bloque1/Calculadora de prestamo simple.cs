using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio04
    {
        public static void Ejecutar() 
    { 
        bool salir = false;
        while (!salir)
        {
        Console.WriteLine("\n===Ejercicio 4: Calculadora de prestamo simple ===");
        // Solicito al usuario el monto del préstamo, la tasa de interés anual y el plazo en meses uso mayormente double ya que se usan decimales
        //la estructura es sencilla y basica financiera
        Console.WriteLine("Ingrese el monto que desea prestar: ");
        double monto = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tasa de interes anual (en porcentaje): ");
        double tasaInteres = double.Parse(Console.ReadLine()) / 100;
        Console.WriteLine("Ingrese el plazo del prestamo en meses: ");
        int plazo = int.Parse(Console.ReadLine()); 
        double interesTotal = monto * tasaInteres * (plazo / 12);
        double montoTotal = monto + interesTotal;
        Console.WriteLine($"\nEl monto total a pagar es: {montoTotal:F2}");

        Console.WriteLine($"La cuota mensual fija es: {(montoTotal / plazo):F2}");

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