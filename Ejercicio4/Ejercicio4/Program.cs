using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumDiv=0,contPerf=0;

            for (int i = 1; contPerf < 4; i++)
            {
                acumDiv = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumDiv += j;
                    }
                }

                if (i == acumDiv)
                {
                    contPerf++;
                    Console.WriteLine("Numero perfecto {0}", i);
                }
            }
            Console.ReadKey();
            
        }
    }
}
