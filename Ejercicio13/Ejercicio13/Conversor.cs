using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(int number)
        {
            String cadena = "";
            number = Convert.ToInt32(Console.ReadLine());
            if(number>0)
            {
                
                while (number > 0)
                {
                    if(number%2==0)
                    {
                        cadena = "0" + cadena;

                    }

                    else
                    {
                        cadena = "1" + cadena;
                    }
                    number = (int)(number / 2);
                }
                Console.WriteLine(cadena);
            }
            else
            {
                Console.WriteLine("Ingrese numeros mayores a 0");
            }
            return cadena;
        }
    }
}
