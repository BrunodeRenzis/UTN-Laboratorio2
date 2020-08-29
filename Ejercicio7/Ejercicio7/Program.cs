using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            int day=0, month=0, year=0,acumDias=0;

            Console.WriteLine("Ingrese día de nacimiento: ");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Mes de nacimiento: ");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año de nacimiento: ");
            year = int.Parse(Console.ReadLine());

            for(int i = day; i<DateTime.Now.Day;i++)
            {
                acumDias += i;
            }

            for(int i = month; i<DateTime.Now.Month;i++)
            {
                switch(month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        acumDias += 31;
                        break;

                    case 2:
                        acumDias += 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        acumDias += 30;
                        break;
                }
            }

            for(int i=year;i<DateTime.Now.Year;i++)
            {
                if (i % 4 == 0)
                {
                    acumDias += 366;
                }

                else
                {
                    acumDias += 365;
                }
            }
            Console.Write(acumDias);
            Console.ReadKey();
        }
    }
}
