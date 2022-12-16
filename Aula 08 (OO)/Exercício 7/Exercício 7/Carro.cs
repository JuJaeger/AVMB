using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Carro
    {
        private string modelo;
        private string cor;
        private int ano_marca;
        private string Chassi;
        private string Proprietário;
        private int Velocidade_max;
        private int Velocidade_atual;
        private int N_portas;
        private bool teto_sola;
        private int N_marchas;
        private bool cambio_automatico;
        private int Vol_combustivel;

        public void aumentar_vel()
        {
            if (Velocidade_atual < Velocidade_max)
            {
                Velocidade_atual++;
            }
        }
    }
}
