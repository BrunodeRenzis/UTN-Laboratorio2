using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente();
            unCliente.SetNombre("Bruno");
            unCliente.SetApellido("de Renzis");
            unCliente.SetDni("39.104.689");
            unCliente.SetUsario("bruno2018");
            unCliente.SetNumeroDeCuenta(1004954032);
            unCliente.SetSaldoCuenta(75000);

            if (unCliente.Login())
            {
                unCliente.MostrarCuenta();
                unCliente.MenuOperaciones();
            }

            else
                Console.WriteLine("No ha ingresado usuario o contraseña correctos");
            Console.ReadKey();

        }
    }
}
