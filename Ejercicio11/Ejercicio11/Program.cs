using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,max=0,min=0,acum=0,cont=0,promedio=0;
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(),out numero) && Validacion.Validar(numero,-100,100))
                {
                    if(i==0)
                    {
                        max = numero;
                        min = numero;
                    }

                    else if (i!=0 && numero>max)
                    {
                        max = numero;
                    }

                    else if (i != 0 && numero < min)
                    {
                        min = numero;
                    }
                    acum += numero;
                    cont++;
                }

            }

            promedio = acum / cont;
            Console.WriteLine("Máximo: {0} Minimo: {1} Promedio: {2}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
