using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuPrincipal.Bloque3
{
    public class Ejercicio20
    {
        public static void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                bool valida = false;
                while(!valida)
                {
                    Console.WriteLine("=== Ejercicio 20: Validacion de contraseña ===");
                    Console.WriteLine("Ingrese una contraseña (minimo 8 caracteres, al menos una letra mayuscula, una letra minuscula y un numero):");
                    string contraseña = Console.ReadLine();

                    bool mayuscula = false;
                    bool minuscula = false;
                    bool numero = false;
                    bool caracter = false;

                    if(contraseña.Length >= 8)
                    {
                        foreach (char c in contraseña)// recorre cada caracter de la contraseña para ver si cumple con los requisitos
                        {
                            if(char.IsUpper(c))// verifica si el caracter es una mayuscula
                                mayuscula = true;
                            if(char.IsLower(c))// verifica si el caracter es una minuscula
                                minuscula = true;
                            if(char.IsDigit(c))// verifica si el caracter es un numero
                                numero = true;
                            if(!char.IsLetterOrDigit(c))// verifica si el caracter es un caracter especial
                                caracter = true; 
                        }       
                        if(mayuscula && minuscula && numero && caracter)
                        {
                            valida= true;
                            Console.WriteLine("Contraseña valida");
                        }
                        else
                        {
                            if(!mayuscula)
                                Console.WriteLine("La contraseña debe tener al menos una letra mayuscula");
                            if(!minuscula)
                                Console.WriteLine("La contraseña debe tener al menos una letra minuscula");
                            if(!numero)
                                Console.WriteLine("La contraseña debe tener al menos un numero");
                            if(!caracter)
                                Console.WriteLine("La contraseña debe tener al menos un caracter especial");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La contraseña debe tener al menos 8 caracteres");
                    }
                }
                Console.WriteLine("\nDesea repetir el programa? (si/no)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                    salir = false;
                else if (respuesta == "no")
                    salir = true;
                while (respuesta != "si" && respuesta != "no")
                {
                if (respuesta != "si" && respuesta != "no")
                {
                    Console.WriteLine("Respuesta no válida, repita su peticion");
                    respuesta = Console.ReadLine().ToLower();
                }
                }
            }
        }
    }
}