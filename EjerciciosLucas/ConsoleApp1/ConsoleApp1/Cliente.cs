using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Cliente
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string usuario;
        private string clave;
        public double nroCuenta;
        public float saldo;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public string GetDni()
        {
            return this.dni;
        }

        public void SetUsario(string usuario)
        {
            this.usuario = usuario;
        }

        public string GetUsuario()
        {
            return this.usuario;
        }

        void SetContraseña(string contraseña)
        {
            this.clave = contraseña;
        }

        string GetContraseña()
        {
            return this.clave;
        }
        public void SetNumeroDeCuenta(double numeroCuenta)
        {
            this.nroCuenta = numeroCuenta;
        }

        public double GetNumeroDeCuenta()
        {
            return this.nroCuenta;
        }

        public void SetSaldoCuenta(float saldo)
        {
            this.saldo = saldo;
        }

        public float GetSaldoCuenta()
        {
            return this.saldo;
        }

        bool LoginUser()
        {
            string usuario;
            string userCompare;
            bool estado = false;
            Console.WriteLine("Ingrese su usuario: ");
            usuario = Console.ReadLine();
            while(String.IsNullOrEmpty(usuario))
            {
                Console.WriteLine("Ingrese su usuario: ");
                usuario = Console.ReadLine();
            }
            userCompare = this.GetUsuario();
            if(usuario == userCompare)
            {
               estado=true;
            }
            return estado;
        }

        bool PasswordUser()
        {
            string password;
            bool estado = false;
            Console.WriteLine("Ingrese su contraseña: ");
            password = Console.ReadLine();
            while (String.IsNullOrEmpty(password))
            {
                Console.WriteLine("Ingrese su contraseña: ");
                password = Console.ReadLine();
            }

            if (password == GenericPassword())
            {
                estado = true;
                Console.WriteLine("Logueo correcto");

                Console.ReadKey();
            }
            return estado;
        }

        public bool Login()
        {
            bool estado = false;
            if(LoginUser() && PasswordUser())
            {
                estado = true;
            }
            return estado;
        }

        private string GenericPassword()
        {
            string password= "abcde12345";
            SetContraseña(password);
            return password;
        }
        public void MostrarCuenta()
        {
            Console.WriteLine("Datos cuenta:\n Nombre: {0}\n Apellido: {1}\n dni: {2}\n Usuario: {3}\n Cuenta Nro: {4}\n Saldo: {5}",this.nombre,this.apellido,this.dni,this.usuario,this.nroCuenta,this.saldo);

        }

        public int MenuOpciones()
        {
            int option;
            Console.WriteLine("\nQue operación desea realizar?\n1-Depositar Dinero\n2-Extracción de dinero\n");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public void MenuOperaciones()
        {
            switch(MenuOpciones())
            {
                case 1:
                    int aumento;
                    Console.WriteLine("Ingrese cuanto desea depositar: ");
                    aumento = int.Parse(Console.ReadLine());
                    AgregarSaldo(aumento);
                    break;

                case 2:
                    int extraccion;
                    Console.WriteLine("Ingrese cuanto desea extraer: ");
                    extraccion = int.Parse(Console.ReadLine());
                    RetirarDinero(extraccion);
                    break;
            }
        }

       
        public void AgregarSaldo(int aumento)
        {
             
             this.saldo+= aumento;
            Console.WriteLine("Su saldo actual es de: {0}", this.saldo);
        }

        public bool RetirarDinero(int extraccion)
        {
            bool estadoTransaccion = false;
            float saldoActual;
            saldoActual = this.saldo - extraccion;
            if(saldoActual>=0)
            {
                Console.WriteLine("Transacción exitosa!");
                Console.WriteLine("Su saldo restante es de: {0}",saldoActual);
                estadoTransaccion = true;
            }
            else
            {
                saldoActual = this.saldo;
                Console.WriteLine("No se ha podido concretar la extracción porque es muy grande, como bokita papa");
                Console.ReadKey();
            }
            return estadoTransaccion;
        }
    }
}
