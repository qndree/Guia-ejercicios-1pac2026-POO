using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio12
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
            Console.WriteLine("\n=== Ejercicio 12: Año bisiesto y días del mes ===");

            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            bool esBisiesto = (año % 4 == 0);

            if (esBisiesto)
                Console.WriteLine("El año es bisiesto.");
            else
                Console.WriteLine("El año no es bisiesto.");

            int dias = 0;
            // Hice las validaciones a partir de if comparando los meses y dias por mes para determinar cuantos dias tiene el mes ingresado, teniendo en cuenta si el año es bisiesto o no para el caso de febrero
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
                mes == 8 || mes == 10 || mes == 12)
            {
                dias = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dias = 30;
            }
            else if (mes == 2)
            {
                if (esBisiesto)
                    dias = 29;
                else
                    dias = 28;
            }
            else
            {
                Console.WriteLine("Mes inválido.");
                return;
            }

            Console.WriteLine("El mes tiene " + dias + " días.");

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