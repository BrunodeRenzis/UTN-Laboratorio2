using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            int num1, num2;
            double resultado = 0;
            char operador;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de operación que desea hacer (+,-,*,/) : ");
            operador = char.Parse(Console.ReadLine());
            resultado = Calculadora.Calcular(num1, num2, operador);
            if(resultado != -9999999)
            {
                Console.WriteLine("El resultado de la operación es: {0}", resultado);
            }

            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            Console.ReadKey();
        }
    }
}
