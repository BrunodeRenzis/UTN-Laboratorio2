using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if(this.nota1 >=4 && this.nota2 >=4)
            {
                Random notaFinalRandom = new Random();
                this.notaFinal = notaFinalRandom.Next(4,10);
            }

            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string cadenaReturn = "";
            cadenaReturn += "Alumno " + this.nombre + " " + this.apellido + "\n";
            cadenaReturn += "Legajo: " + this.legajo + "\n";
            cadenaReturn += "Nota 1: " + this.nota1 + "Nota 2: " + this.nota2 + "\n";
            if (this.notaFinal > 0)
            {
                cadenaReturn += "Nota final: " + this.notaFinal + "\n";
            }

            else
            {
                cadenaReturn += "Nota final: Desaprobado";
            }

            return cadenaReturn;
        }
    }
}
