using MenuPrincipal.Bloque1;
using MenuPrincipal.Bloque2;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Este es el menu principal donde se pueden seleccionar los ejercicios a ejecutar
            Console.WriteLine("\n=== Menú de ejercicios ===");
            Console.WriteLine("1 - Calculadora de IMC");
            Console.WriteLine("2 - Menu de conversion de temperaturas");
            Console.WriteLine("3 - Desglose de billetes");
            Console.WriteLine("4 - Calculadora de prestamo simple");
            Console.WriteLine("5 - Tiempo transcurrido");
            Console.WriteLine("6 - Área y perímetro");
            Console.WriteLine("7 - Conversión de unidades de almacenamiento");
            Console.WriteLine("8 - Calculo de salario semanal");
            Console.WriteLine("9 - Clasificación de triángulos");
            Console.WriteLine("10 - Sistema de calificaciones UNAH");
            Console.WriteLine("11 - Calculadora de descuentos");
            Console.WriteLine("12 - Año bisiesto y días del mes");
            Console.WriteLine("13 - Validador de fecha");
            Console.WriteLine("14 - Cajero automático");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("Seleccione el ejercicio que desea ejecutar (0 para salir):");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": Ejercicio01.Ejecutar(); break;
                case "2": Ejercicio02.Ejecutar(); break;
                case "3": Ejercicio03.Ejecutar(); break;
                case "4": Ejercicio04.Ejecutar(); break;
                case "5": Ejercicio05.Ejecutar(); break;
                case "6": Ejercicio06.Ejecutar(); break;
                case "7": Ejercicio07.Ejecutar(); break;
                case "8": Ejercicio08.Ejecutar(); break;
                case "9": Ejercicio09.Ejecutar(); break;
                case "10": Ejercicio10.Ejecutar(); break;
                case "11": Ejercicio11.Ejecutar(); break;
                case "12": Ejercicio12.Ejecutar(); break;
                case "13": Ejercicio13.Ejecutar(); break;
                case "14": Ejercicio14.Ejecutar(); break;
               /* case "15": Ejercicio15.Ejecutar(); break;
                case "16": Ejercicio16.Ejecutar(); break;
                case "17": Ejercicio17.Ejecutar(); break;
                case "18": Ejercicio18.Ejecutar(); break;
                case "19": Ejercicio19.Ejecutar(); break;
                case "20": Ejercicio20.Ejecutar(); break;
                case "21": Ejercicio21.Ejecutar(); break;
                case "22": Ejercicio22.Ejecutar(); break;
                case "23": Ejercicio23.Ejecutar(); break;
                case "24": Ejercicio24.Ejecutar(); break;
                case "25": Ejercicio25.Ejecutar(); break;
                case "26": Ejercicio26.Ejecutar(); break;
                case "27": Ejercicio27.Ejecutar(); break;
                case "28": Ejercicio28.Ejecutar(); break;
                case "29": Ejercicio29.Ejecutar(); break;
                case "30": Ejercicio30.Ejecutar(); break; */
                case "0": return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}