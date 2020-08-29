using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            double ladoCuadrado=4, radioCirculo=6, baseTriangulo=3, alturaTriangulo=2;

            Console.WriteLine("El area del cuadrado es {0}\nEl area del círculo es: {1}\nEl area del triángulo es: {2}", CalculoDeArea.CalcularCuadrado(ladoCuadrado),CalculoDeArea.CalcularCirculo(radioCirculo),CalculoDeArea.CalcularTriangulo(baseTriangulo,alturaTriangulo));
            Console.ReadKey();
        }
    }
}
