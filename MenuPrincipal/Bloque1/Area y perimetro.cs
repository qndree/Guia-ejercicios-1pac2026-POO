using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque1
{
    public class Ejercicio06
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("\n=== Ejercicio 6: Área y perímetro ===");
                Console.WriteLine("1 - Círculo");
                Console.WriteLine("2 - Triángulo");
                Console.WriteLine("3 - Rectángulo");
                Console.WriteLine("4 - Trapecio");
                Console.WriteLine("0 - Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":Circulo(); break;
                    case "2":Triangulo(); break;
                    case "3":Rectangulo(); break;
                    case "4":Trapecio(); break;
                    case "0":
                    salir = true; break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }    
        }
}
        static void Circulo()
        {
            // Gracias a la funcion leerpositivo que nos brinda c# se puede evaluar que los valores ingresados sean positivos sin necesidad de extender mas el codigo usando if 
            // pero para poder usarla necesitamos una funcion aparte y declararla como static y trabajarla separada de las demas funciones
            // lo mismo con la funcion mostrarresultados con esta simple funcion se imprimen en pantalla los datos trabajados en una forma mas corta sin usar mas lineas
            Console.WriteLine("\n--- Círculo ---");
            double radio = LeerPositivo("Ingrese el radio: ");
            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;
            MostrarResultados(area, perimetro);
        }

        static void Triangulo()
        {
            Console.WriteLine("\n--- Triángulo ---");
            double baseT = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");
            double lado1 = LeerPositivo("Ingrese lado 1: ");
            double lado2 = LeerPositivo("Ingrese lado 2: ");

            double area = (baseT * altura) / 2;
            double perimetro = baseT + lado1 + lado2;
            MostrarResultados(area, perimetro);
        }

        static void Rectangulo()
        {
            Console.WriteLine("\n--- Rectángulo ---");
            double baseR = LeerPositivo("Ingrese la base: ");
            double altura = LeerPositivo("Ingrese la altura: ");

            double area = baseR * altura;
            double perimetro = 2 * (baseR + altura);
            MostrarResultados(area, perimetro);
        }

        static void Trapecio()
        {
            Console.WriteLine("\n--- Trapecio ---");
            double baseMayor = LeerPositivo("Ingrese base mayor: ");
            double baseMenor = LeerPositivo("Ingrese base menor: ");
            double altura = LeerPositivo("Ingrese altura: ");
            double lado1 = LeerPositivo("Ingrese lado 1: ");
            double lado2 = LeerPositivo("Ingrese lado 2: ");

            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perimetro = baseMayor + baseMenor + lado1 + lado2;
            MostrarResultados(area, perimetro);
        }

        static double LeerPositivo(string mensaje)
        {
            double valor;
            do
            {
                Console.Write(mensaje);
                valor = double.Parse(Console.ReadLine());

                if (valor <= 0)
                    Console.WriteLine("Debe ingresar un valor positivo.");
            }
            while (valor <= 0);

            return valor;
        }

        static void MostrarResultados(double area, double perimetro)
        {
            Console.WriteLine("Área: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2"));
        }
    }
}