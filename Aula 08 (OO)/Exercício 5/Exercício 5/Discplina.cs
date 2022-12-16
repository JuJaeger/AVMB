using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Discplina
    {
        public string disciplina;
        public int carga_horaria;

        public Discplina(string disciplina, int carga_horaria)
        {
            this.disciplina = disciplina;
            this.carga_horaria = carga_horaria;
        }

        public string exibir()
        {
             return "Disciplina " + disciplina + " é feita em " + carga_horaria + " horas!";
        }
    }
}
