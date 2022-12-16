using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Lampada
    {
        public int ligada;
        public double potencia;
        public void acesa()
        {
            ligada = 2;
            potencia = 200;
        }

        public void apagada()
        {
            ligada = 0;
            potencia = 0;
        }

        public void meia_luz()
        {
            ligada = 1;
            potencia = 100;
        }
    }
}
