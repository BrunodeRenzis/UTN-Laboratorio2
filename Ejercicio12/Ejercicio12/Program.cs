using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio12";
            int acumulador = 0, number;
            char respuesta = 's';

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(),out number))
                {
                    acumulador += number;
                    Console.WriteLine("Desea agregar otro número? S/N");
                    char.TryParse(Console.ReadLine(), out respuesta);
                }
            } while (ValidaRespuesta.ValidaS_N(respuesta));

            Console.WriteLine("La suma total es: {0}", acumulador);
            Console.ReadLine();
        }
    }
}
