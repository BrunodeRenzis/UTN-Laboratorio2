using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno [] alumnos = new Alumno[3];
            
            for(int i=0;i<alumnos.Length; i++)
            {
                alumnos[i] = new Alumno();
                Random nota1Ran = new Random();
                Random nota2Ran = new Random();

                byte nota1 = (byte)nota1Ran.Next(1, 9); //Devuelve un numero positvo dentro del rango.
                byte nota2 = (byte)nota2Ran.Next(1, 9);

                Console.WriteLine("Ingrese nombre del {0} alumno: ", i + 1);
                alumnos[i].nombre = Console.ReadLine();

                Console.WriteLine("Ingrese apellido del {0} alumno: ", i + 1);
                alumnos[i].apellido = Console.ReadLine();

                Console.WriteLine("Ingrese legajo del {0} alumno: ", i + 1);
                while(!int.TryParse(Console.ReadLine(),out alumnos[i].legajo))
                {
                    Console.Write("Ingrese solo datos numéricos del legajo: ");
                    alumnos[i].legajo = int.Parse(Console.ReadLine());
                }

                alumnos[i].Estudiar(nota1, nota2);
                alumnos[i].CalcularFinal();
            }
           
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine(alumnos[i].Mostrar());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
