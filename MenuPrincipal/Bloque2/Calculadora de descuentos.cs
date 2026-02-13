using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 11: Calculadora de descuentos ===");

                Console.WriteLine("Ingrese el monto de la compra:");
                double monto = Convert.ToDouble(Console.ReadLine());
                //Evaluo de la manera mas sencilla con if todos los casos
                if(monto >= 500 && monto < 1000)
                {
                    double descuento = monto * 0.05;
                    double total = monto - descuento;
                    Console.WriteLine($"El precio original es: {monto}");
                    Console.WriteLine($"Descuento aplicado: {descuento}");
                    Console.WriteLine($"Total a pagar: {total}");
                }
                if(monto >= 1000 && monto < 2500)
                {
                    double descuento = monto * 0.10;
                    double total = monto - descuento;
                    Console.WriteLine($"El precio original es: {monto}");
                    Console.WriteLine($"Descuento aplicado: {descuento}");
                    Console.WriteLine($"Total a pagar: {total}");
                }
                if(monto >= 2500)
                {
                    double descuento = monto * 0.15;
                    double total = monto - descuento;
                    Console.WriteLine($"El precio original es: {monto}");
                    Console.WriteLine($"Descuento aplicado: {descuento}");
                    Console.WriteLine($"Total a pagar: {total}");
                }
                if(monto < 500)
                {
                    Console.WriteLine($"El precio original es: {monto}");
                    Console.WriteLine("No se aplica ningun descuento.");
                    Console.WriteLine($"Total a pagar: {monto}");
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