﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Gato : Animal
    {
        public override void fazerBarulho()
        {
            Console.WriteLine("Miau-Miau!");
        }
    }
}