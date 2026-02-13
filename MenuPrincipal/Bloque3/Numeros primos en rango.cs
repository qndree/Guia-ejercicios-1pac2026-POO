using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio16
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 16: Numeros primos en rango ===");

                Console.WriteLine("Ingrese el numero inicial del rango:");
                int inicio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero final del rango:");
                int fin = int.Parse(Console.ReadLine());

                Console.WriteLine($"Los numeros primos entre {inicio} y {fin} son: ");
                for (int i = inicio; i <= fin; i++)// uso una estructura tipo matriz para recorrer el rango y verificar cuales numeros son primos
                {
                    int esprimo = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)// con este if verifico si el numero es divisible entre j, si es entonces aumento el contador de esprimo
                            esprimo++;
                    }
                    if (esprimo == 2)// si el contador de esprimo es igual a 2, entonces el numero es primo ya que solo es divisible entre 1 y el mismo
                        Console.WriteLine($"{i} es un numero primo");
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