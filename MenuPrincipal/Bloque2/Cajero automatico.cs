using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque2
{
    public class Ejercicio14
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                // Saldo de ejemplo en el cajero automático
                int saldo = 5000;

            Console.WriteLine("\n=== Ejercicio 14: Cajero Automático ===");
            Console.WriteLine("Saldo disponible: L " + saldo);

            Console.Write("Ingrese monto a retirar: ");
            int monto = int.Parse(Console.ReadLine());

            if (monto <= 0)
            {
                Console.WriteLine("Monto inválido.");
                return;
            }

            if (monto % 20 != 0)
            {
                Console.WriteLine("El monto debe ser múltiplo de 20.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }

            Console.WriteLine("\nRetiro exitoso. Billetes entregados:");

            int restante = monto;
            //b de billete
            int b500 = restante / 500;
            restante = restante % 500;

            int b100 = restante / 100;
            restante = restante % 100;

            int b50 = restante / 50;
            restante = restante % 50;

            int b20 = restante / 20;

            if (b500 > 0) Console.WriteLine("Billetes de 500: " + b500);
            if (b100 > 0) Console.WriteLine("Billetes de 100: " + b100);
            if (b50 > 0) Console.WriteLine("Billetes de 50: " + b50);
            if (b20 > 0) Console.WriteLine("Billetes de 20: " + b20);

            saldo -= monto;
            Console.WriteLine("\nSaldo restante: L " + saldo);
            
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