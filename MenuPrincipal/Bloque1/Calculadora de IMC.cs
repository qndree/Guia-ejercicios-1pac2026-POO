using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    class Ejercicio01
    {
        public static void Ejecutar()
    {
        bool salir = false;
        while (!salir)
        {
        Console.Clear();    
        Console.WriteLine("\n=== Ejercicio 1: Calculadora de IMC ===");

        Console.Write("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("\nSu IMC es: " + imc.ToString("F2"));
        // Estructura sencilla de if para evaluar el resultado del imc y mostrar la categoria a la que pertenece cada resultado
        if (imc < 18.5)
            Console.WriteLine("Categoría: Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Categoría: Normal");
        else if (imc < 30)
            Console.WriteLine("Categoría: Sobrepeso");
        else
            Console.WriteLine("Categoría: Obesidad");

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