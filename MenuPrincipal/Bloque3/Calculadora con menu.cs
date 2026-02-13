using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio22
    {
        public static void Ejecutar()
        {
            double resultado = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 22: Calculadora con menú ===");

                Console.WriteLine($"Resultado anterior: {resultado}");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicacion");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Potencia");
                Console.WriteLine("6 - Raiz cuadrada");
                Console.WriteLine("7 - Porcentaje");
                Console.WriteLine("8 - Reiniciar resultado");
                Console.WriteLine("0 - Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero:");
                        double Suma = double.Parse(Console.ReadLine());
                        resultado += Suma;
                        break;

                    case 2:
                        Console.WriteLine("Ingrese numero:");
                        double Resta = double.Parse(Console.ReadLine());
                        resultado -= Resta;
                        break;

                    case 3:
                        Console.WriteLine("Ingrese numero:");
                        double Multi = double.Parse(Console.ReadLine());
                        resultado *= Multi;
                        break;

                    case 4:
                        Console.WriteLine("Ingrese numero:");
                        double Division = double.Parse(Console.ReadLine());
                        if (Division != 0)
                            resultado /= Division;
                        else
                            Console.WriteLine("No se puede dividir entre 0");
                        break;

                    case 5:
                        Console.WriteLine("Ingrese potencia:");
                        double potencia = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(resultado, potencia);
                        break;

                    case 6:
                        if (resultado >= 0)
                            resultado = Math.Sqrt(resultado);
                        else
                            Console.WriteLine("No se puede sacar raiz de numero negativo");
                        break;

                    case 7:
                        Console.WriteLine("Ingrese porcentaje:");
                        double porcentaje = double.Parse(Console.ReadLine());
                        resultado = resultado * porcentaje / 100;
                        break;

                    case 8:
                        resultado = 0;
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
    }
}