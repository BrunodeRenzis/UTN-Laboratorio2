using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return (lado*lado);
        }
        public static double CalcularTriangulo(double baseTriangulo,double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo);
        }
        public static double CalcularCirculo(double radio)
        {
            return (Math.PI * Math.Pow(radio,2));
        }
    }
}
