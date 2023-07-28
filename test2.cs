using System;

namespace Test2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¡Hola! Este es otro programa de prueba en C# (Test2).");
            Console.WriteLine("Por favor, ingrese su edad:");

            // Leer la edad ingresada por el usuario
            string input = Console.ReadLine();

            // Intentar convertir la edad ingresada a entero
            if (int.TryParse(input, out int edad))
            {
                // Verificar si la persona es mayor de edad
                if (edad >= 18)
                {
                    Console.WriteLine("¡Eres mayor de edad! Puedes ingresar al programa.");
                }
                else
                {
                    Console.WriteLine("Eres menor de edad. No tienes acceso al programa.");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es una edad válida.");
            }
        }
