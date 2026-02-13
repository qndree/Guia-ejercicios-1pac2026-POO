using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque5
{
    public class Ejercicio30
    {
        public static void Ejecutar()
        {

            int numProductos = 5;

            // los arreglos para cada bloque del inventario
            int[] codigos = new int[numProductos];
            string[] nombres = new string[numProductos];
            int[] cantidades = new int[numProductos];
            double[] precios = new double[numProductos];

            Console.Clear();
            Console.WriteLine("=== Ejercicio 30: Inventario simple ===");

            Console.WriteLine("=== Inventario Inicial ===");
            for (int i = 0; i < numProductos; i++) //ingerso de los productos
            {
                Console.WriteLine($"\nProducto {i + 1}:");
                Console.Write("Código: ");
                codigos[i] = int.Parse(Console.ReadLine());
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Cantidad: ");
                cantidades[i] = int.Parse(Console.ReadLine());
                Console.Write("Precio unitario: ");
                precios[i] = double.Parse(Console.ReadLine());
            }

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de Inventario ===");
                Console.WriteLine("1 - Mostrar inventario");
                Console.WriteLine("2 - Buscar producto por código");
                Console.WriteLine("3 - Actualizar cantidad de producto");
                Console.WriteLine("4 - Calcular valor total del inventario");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        Console.Clear();
                        Console.WriteLine("Código\tNombre\tCantidad\tPrecio");
                        for (int i = 0; i < numProductos; i++)// Mostrar inventario
                        {
                            Console.WriteLine($"{codigos[i]}\t{nombres[i]}\t{cantidades[i]}\t\t{precios[i]:F2}");
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Write("Ingrese código del producto a buscar: ");
                        int codigoBuscar = int.Parse(Console.ReadLine());
                        int index = Array.IndexOf(codigos, codigoBuscar);
                        if (index != -1)
                        {
                            Console.WriteLine($"Producto encontrado: {nombres[index]}, Cantidad: {cantidades[index]}, Precio: {precios[index]:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Write("Ingrese código del producto a actualizar: ");
                        int codigoActualizar = int.Parse(Console.ReadLine());
                        int idx = Array.IndexOf(codigos, codigoActualizar);
                        if (idx != -1)
                        {
                            Console.Write($"Cantidad actual de {nombres[idx]}: {cantidades[idx]}. Nueva cantidad: ");
                            cantidades[idx] = int.Parse(Console.ReadLine());
                            Console.WriteLine("Cantidad actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4": 
                        double total = 0;
                        for (int i = 0; i < numProductos; i++)// Valor total del inventario
                        {
                            total += cantidades[i] * precios[i];
                        }
                        Console.WriteLine($"El valor total del inventario es: {total:F2}");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
