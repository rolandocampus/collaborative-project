using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¡Hola! Este es otro programa de prueba en C#.");
            Console.WriteLine("Ingrese el nombre:");

            // Leer el nombre ingresado por el usuario
            string nombre = Console.ReadLine();

            // Mostrar un saludo personalizado
            Console.WriteLine($"¡Hola, {nombre}! Bienvenidx al programa de prueba.");

            // Realizar una operación matemática (ejemplo, suma de dos números)
            int numero1 = 10;
            int numero2 = 5;
            int resultado = numero1 + numero2;

            // Mostrar el resultado de la operación
            Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es: {resultado}");
        }
    }
}
