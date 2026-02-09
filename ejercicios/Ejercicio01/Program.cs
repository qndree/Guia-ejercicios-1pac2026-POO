using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora de IMC ===");

        Console.Write("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("\nSu IMC es: " + imc.ToString("F2"));

        if (imc < 18.5)
            Console.WriteLine("Categoría: Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Categoría: Normal");
        else if (imc < 30)
            Console.WriteLine("Categoría: Sobrepeso");
        else
            Console.WriteLine("Categoría: Obesidad");
    }
}