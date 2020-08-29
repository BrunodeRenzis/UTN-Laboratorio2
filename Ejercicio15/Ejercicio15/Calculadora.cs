using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(int num1,int num2,char operacion)
        {
            int resultado=0;
            switch(operacion)
            {
                case '+':
                    resultado=(num1 + num2);
                    break;

                case '-':
                    resultado=(num1 - num2);
                    break;
                case '*':
                    resultado=(num1 * num2);
                    break;

                case '/':
                    if (Validar(num2))
                        resultado=(num1 / num2);
                    else
                        resultado = -9999999;
                    break;
                    
            }
            return resultado;
        }

        static bool Validar(int num2)
        {
            if(num2!=0)
            {
                return true;
            }

            return false;
        }
    }
}
