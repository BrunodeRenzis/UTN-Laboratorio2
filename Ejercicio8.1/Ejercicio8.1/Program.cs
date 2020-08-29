using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            int horas=0,añosTrabajados=0,numeroEmpleados;
            float importeCobrado = 0,valorAntiguedad=0, valorHora = 0, valorNeto=0,importeSinAntiguedad=0,importeBruto=0,importeDescuento=0;
            string nombre;

            Console.WriteLine("Ingrese la cantidad de empleados a registrar: ");
            numeroEmpleados = int.Parse(Console.ReadLine());

            for(int i=0;i<numeroEmpleados;i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de hora en $ ");
                valorHora = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese antiguedad del empleado: ");
                añosTrabajados = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad horas del empleado: ");
                horas = int.Parse(Console.ReadLine());

                importeSinAntiguedad = valorHora * horas;
                valorAntiguedad = añosTrabajados * 150;
                importeBruto = ((importeSinAntiguedad + valorAntiguedad)*30);
                importeDescuento = (importeBruto * (float)0.13);
                importeCobrado = importeBruto - importeDescuento;
                Console.WriteLine("Empleado: {0}\nAntiguedad: {1}\nValor hora: {2}\nSueldo bruto: {3}\nTotal de descuentos: {4}\n Total cobrado: {5}",nombre,añosTrabajados,valorHora,importeBruto,importeDescuento,importeCobrado);
            }

            Console.ReadKey();

        }
    }
}
