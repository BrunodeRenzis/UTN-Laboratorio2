using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";
            double number,cuadrado,cubo;
            Console.WriteLine("Ingrese un numero: ");
            number = int.Parse(Console.ReadLine());
            cuadrado = Math.Pow(number,2);
            cubo = Math.Pow(number, 3);

            Console.WriteLine("El numero ingresado es {0} su cuadrado es {1} y su cubo es {2}", number, cuadrado, cubo);
        }
    }
}
