using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio 1";
            int number=0, max=0, min=0, acum=0;
            float prom = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                number = int.Parse(Console.ReadLine());

                if(i==0)
                {
                    max = number;
                    min = number;
                }

                else if (number > max)
                {
                    max = number;
                }

                else if (number < min)
                {
                    min = number;
                }

                acum += number;

            }

            prom = (float)acum /5;

            Console.WriteLine("El máximo es {0}, el mínimo es {1}, la suma es {2} y el promedio es {3}", max,min,acum,prom);


        }

    }


}