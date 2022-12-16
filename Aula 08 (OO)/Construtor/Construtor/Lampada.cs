using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;
        public string cor;
        public Lampada(double potencia, string cor)
        {
            this.potencia = potencia;
            this.cor = cor;
        }
        public void ligar()
        {
            if (!estaLigada())
            {
                ligada = true;
                Console.WriteLine("Ligando a lampada!");
            }

            else
            {
                Console.WriteLine("Já está ligada");
            }
        }

        public void desligar()
        {
            if (estaLigada() )
            {
                ligada = false;
                Console.WriteLine("Desligando a lampada!");
            }

            else
            {
                Console.WriteLine("Já está desligada!");
            }
        }

        public bool estaLigada()
        {
            return ligada;
        }
    }
}
