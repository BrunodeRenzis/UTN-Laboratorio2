using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";
            int number;
            string ast = "**";
            Console.WriteLine("Ingrese un numero: ");
            number = int.Parse(Console.ReadLine());
            for(int i=0;i<number;i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("*\n");
                }

                else
                {
                    Console.WriteLine("*"+"{0}\n", ast);
                    ast += "**";
                }

            }
            Console.ReadKey();
        }
    }
}
