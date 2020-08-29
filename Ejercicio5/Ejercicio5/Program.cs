using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";

            int number,acumAnteriores=0,acumPosteriores=0;
            Console.WriteLine("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(),out number))
            {
                for (int i = number; i > 0; i--)
                {
                    acumPosteriores = 0;
                    acumAnteriores = 0;

                    for (int j = i - 1; j > 0; j--)
                    {
                        acumAnteriores += j;
                    }

                    for (int k = i + 1; acumPosteriores < acumAnteriores; k++)
                    {
                        acumPosteriores += k;
                    }

                    if(acumPosteriores==acumAnteriores)
                    {
                        Console.WriteLine("Centro numerico {0}", i);
                    }
                }
            }
                    Console.ReadKey();

        }
    }
}
