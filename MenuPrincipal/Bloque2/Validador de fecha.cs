using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio13
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
            Console.Clear();    
            Console.WriteLine("\n=== Ejercicio 13: Validador de fecha ===");

            Console.Write("Ingrese el día: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año: ");
            int anio = int.Parse(Console.ReadLine());

            bool esBisiesto = (anio % 4 == 0);
            int diasDelMes = 0;

            if (anio <= 0)
            {
                Console.WriteLine("Fecha inválida: año incorrecto.");
                return;
            }

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Fecha inválida: mes incorrecto.");
                return;
            }
            // Igual al ejercicio anterior pero con validacion de fecha completa real osea si es valida, incluyendo año bisiesto y cantidad de dias por mes
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
                mes == 8 || mes == 10 || mes == 12)
            {
                diasDelMes = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasDelMes = 30;
            }
            else if (mes == 2)
            {
                if (esBisiesto)
                    diasDelMes = 29;
                else
                    diasDelMes = 28;
            }

            if (dia < 1 || dia > diasDelMes)
            {
                Console.WriteLine("Fecha inválida: día incorrecto.");
                return;
            }

            Console.WriteLine("La fecha ingresada ES válida.");
            
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