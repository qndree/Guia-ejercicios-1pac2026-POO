using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio03
    {
        public static void Ejecutar()
    {
        bool salir = false;
        while (!salir)
        {
        Console.WriteLine("\n=== Ejercicio 3: Desglose de billetes ===");
         
        Console.Write("Ingrese el monto a desglosar: ");
        int monto = int.Parse(Console.ReadLine());
        // Almaceno en un arreglo los billetes ejemplares dados por el ejercicio 
        int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine("\nDesglose de billetes:");
        // foreach es una estructura que se usa para recorrer cada elemento del arreglo 
        // int b es el tipo de variable (se declara una variable cualquiera) y billetes es el arreglo que se va a recorrer
        // en la primera vuelta b toma el valor de 500 y usa la formula monto %= b y almacena el residuo para luego seguir con el siguiente billete, asi sucesivamente hasta llegar al ultimo billete de 1
        foreach (int b in billetes)
        {
            int cantidad = monto / b;
            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} billete(s) de {b}");
                monto %= b;
            }
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