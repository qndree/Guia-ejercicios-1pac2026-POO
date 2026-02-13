using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque5
{
    public class Ejercicio29
    {
        public static void Ejecutar()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Ejercicio 29: Juego de gato");

                char[,] tablero = new char[3, 3]; // matriz 3x3
                int movimientos = 0;
                bool hayGanador = false;

                for (int i = 0; i < 3; i++)// imprime e inicia el tablero
                    for (int j = 0; j < 3; j++)
                        tablero[i, j] = ' ';

                char jugadorActual = 'X';

                while (!hayGanador && movimientos < 9)
                {
                    Console.Clear();
                    Console.WriteLine("=== Juego de Gato (Tic-Tac-Toe) ===\n");
                    MostrarTablero(tablero);

                    Console.WriteLine($"\nTurno del jugador {jugadorActual}");
                    int fila = -1, columna = -1;

                    bool entradaValida = false;//valida la entrada del njugador
                    while (!entradaValida)
                    {
                        Console.Write("Ingrese fila (1-3): ");
                        fila = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Ingrese columna (1-3): ");
                        columna = int.Parse(Console.ReadLine()) - 1;

                        if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ')
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Movimiento no válido, intente de nuevo.");
                        }
                    }

                    tablero[fila, columna] = jugadorActual;//coloca la jugada
                    movimientos++;

                    if (RevisarGanador(tablero, jugadorActual))
                    {
                        hayGanador = true;
                        Console.Clear();
                        MostrarTablero(tablero);
                        Console.WriteLine($"\n¡Felicidades! El jugador {jugadorActual} ha ganado!");
                        break;
                    }

                    jugadorActual = (jugadorActual == 'X') ? 'O' : 'X'; //cambia de turno
                }

                if (!hayGanador && movimientos == 9)//por si hay empate
                {
                    Console.Clear();
                    MostrarTablero(tablero);
                    Console.WriteLine("\n¡Empate! No hay ganador.");
                }

                bool respuestaValida = false;//pregunta si desea reiniciar
                while (!respuestaValida)
                {
                    Console.WriteLine("\n¿Desea jugar otra vez? (si/no)");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta == "si")
                    {
                        respuestaValida = true;
                    }
                    else if (respuesta == "no")
                    {
                        respuestaValida = true;
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("Respuesta no válida. Intente nuevamente.");
                    }
                }
            }
        }

        static void MostrarTablero(char[,] tablero)
        {
            Console.WriteLine("  1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  ---------");
            }
        }

        static bool RevisarGanador(char[,] tablero, char jugador) 
        {
            
            for (int i = 0; i < 3; i++)//filas y columnas
            {
                if ((tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) ||
                    (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador))
                    return true;
            }

            // Diagonales
            if ((tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) ||
                (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador))
                return true;

            return false;
        }
    }
}