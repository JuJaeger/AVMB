using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Motor
    {
        private string nomeFabricante;
        private int potencia;
        private string tipo;

        public void associar(string nomeFabricante, int potencia, string tipo)
        {
            this.nomeFabricante = nomeFabricante;
            this.potencia = potencia;
            this.tipo = tipo;
        }

        public string retornar()
        {
            return "Nome do Fabricante: " + nomeFabricante + " Potencia: " + potencia + " Tipo:" + tipo;
        }
    }
}
