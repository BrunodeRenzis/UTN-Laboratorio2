using System;

namespace Ejercicio3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int number,cont=0;
            Console.WriteLine("Ingrese un numero: ");
            number=int.Parse(Console.ReadLine());
            while (number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        cont++;
                    }

                    if (cont > 2)
                    {
                        break;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine("{0} Es primo", number);
                }
                cont = 0;
                number--;
            }
            Console.ReadKey();
        }

    }
}
