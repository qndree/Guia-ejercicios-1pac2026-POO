using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio18
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 18: Factorial y Combinaciones ===");

                Console.WriteLine("Ingrese un numero para calcular su factorial: ");
                int numero = int.Parse(Console.ReadLine());

                long factorial = 1;
                for (int i = 1; i <= numero; i++)// uso un for para calcular el factorial del numero ingresado, por el lenguaje de computadora se tiene que hacer en orden asendente en vez de descendente ya que es mas sencillo
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"El factorial de {numero} es: {factorial}");
                
                Console.WriteLine("Ahora ingrese el numero (n) para calcular sus combinaciones: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("E ingrese el numero (r): ");
                int r = int.Parse(Console.ReadLine());

                while (r > n)
                {
                    Console.WriteLine("r no puede ser mayor que n, Ingrese nuevamente r:");
                    r = int.Parse(Console.ReadLine());
                }

                long factorialn = 1;
                for (int i= 1; i <= n; i++)
                {
                    factorialn = factorialn * i;
                }

                long factorialr = 1;
                for (int i = 1; i <= r; i++)
                {
                    factorialr = factorialr * i;
                }

                long factorialnr = 1;
                for (int i = 1; i <= (n - r); i++)// calculo de un solo el factorial de n-r para no tener que hacer la resta en cada ciclo del for de las combinaciones
                {
                    factorialnr = factorialnr * i;
                }
                long combinaciones = factorialn / (factorialr * factorialnr);// uso la formula de combinaciones que es n! / (r! * (n-r)!)
                Console.WriteLine($"Las combinaciones de {n} son: {combinaciones}");

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