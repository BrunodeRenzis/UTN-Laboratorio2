using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=5;
            string binario="";
            binario=Conversor.DecimalBinario(number);
            Console.WriteLine("El numero binario es: {0}",binario);
            Console.ReadKey();
        }
    }
}
