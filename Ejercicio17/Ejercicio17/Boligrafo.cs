using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public short cantidadTintaMaxima;
        short tinta;
        ConsoleColor color;
        public const short cantidadMaximaTinta = 100;
        
        
        public Boligrafo(short tinta,ConsoleColor color)
        {

        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            tinta = ;
        }

        public bool Pintar(short gasto,out string dibujo)
        {

        }

        public void Recargar()
        {

        }

    }
}
