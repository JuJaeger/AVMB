using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    abstract class Animal
    {
        int distanciaPercorrida = 0;

        public abstract void fazerBarulho();

        public void andar()
        {
            distanciaPercorrida++;
        }

        public void treinar()
        {
            andar();
            fazerBarulho();
        }
    }
}
