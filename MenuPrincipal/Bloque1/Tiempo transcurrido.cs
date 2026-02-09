using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio05
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n=== Ejercicio 5: Tiempo transcurrido ===");

                Console.WriteLine("Ingrese la hora de inicio (formato Hora:minuto:segundo): ");
                string horaInicio = Console.ReadLine();
                Console.WriteLine("Ingrese la hora de fin (formato Hora:minuto:segundo): ");
                string horaFin = Console.ReadLine();
                // C# nos proporciona timespan para trabajar con horas, minutos y segundos, lo que facilita el calculo del tiempo transcurrido
                // este tipo de es una automatizacion de interpretar el ingreso de los datos proporcionados por el usuario
                // el TimeSpan.Parse es un metodo que convierte una cadena de texto en un TimeSpan, siempre y cuando la cadena tenga el formato correcto (en este caso, "Hora:minuto:segundo")
                TimeSpan inicio = TimeSpan.Parse(horaInicio);
                TimeSpan fin = TimeSpan.Parse(horaFin);
                TimeSpan tiempoTranscurrido;
                // Este if es por si el usuario ingresa una hora de fin que es menor a la hora de inicio lo cual haria que el resultado del tiempo transcurrido sea negativo
                // por ejemplo hora de fin 01:00:00 - hora de inicio 23:00:00 = - 22:00:00, lo cual no tiene sentido
                if (fin < inicio)
                {
                // Por eso uso el TimeSpan.FromDays(1) esto es igual a 1 dia como dice su nombre osea 24 horas, lo que hace es que al sumar esto a la hora de fin, se obtiene un resultado positivo
                // al cual se le resta la hora de inicio y se obtiene el resultado    
                    tiempoTranscurrido = (fin + TimeSpan.FromDays(1)) - inicio;
                }
                else
                {
                    tiempoTranscurrido = fin - inicio;
                }
                Console.WriteLine($"\nEl tiempo transcurrido es: {tiempoTranscurrido}");

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