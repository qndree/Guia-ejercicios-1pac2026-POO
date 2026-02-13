using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio19
    {
        public static void Ejecutar()
        {
            Console.Clear();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("=== Ejercicio 19: Juego de adivinanza ===");
                Random random = new Random();
                int numero = random.Next(100)+1;// genero un numero aleatorio entre 1 y 100
                int intentos = 0;
                bool adivinado = false;
                while (!adivinado && intentos < 7)// uso un while para evaluar si adivina o se le acaban los intentos
                {
                    Console.WriteLine("Ingrese un numero entre 1 y 100: ");
                    int adivinanza = int.Parse(Console.ReadLine());
                    intentos++;
                    if (adivinanza == numero)
                    {
                        adivinado = true;
                        Console.WriteLine($"Felicidades ha adivinado el numero en {intentos} intentos");
                    }
                    else if (adivinanza > numero)
                    {
                        Console.WriteLine("El numero es menor");
                    }
                    else if (adivinanza < numero)
                    {
                        Console.WriteLine("El numero es mayor");
                    }
                    if (intentos > 6)
                    {
                        Console.WriteLine($"\nNo ha logrado adivinar, el numero era {numero}");
                    }
                }
                int intentosRestantes = 7 - intentos;// para mostrar los intentos que le sobraron al usuario
                if(intentos ==7)
                {
                    Console.WriteLine("Se le acabaron los intentos");
                }
                else if (intentos <7)
                {
                Console.WriteLine($"Le sobraron {intentosRestantes}");
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