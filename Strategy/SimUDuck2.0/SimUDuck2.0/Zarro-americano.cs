﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck2._0
{
    internal class Zarro_americano : Pato, IPatoStrategy
    {
        public void Quack()
        {
            QuackSei();
        }
        public void ComportamentoVoo()
        {
            VoarSei();
        }
        internal override void Display()
        {
            Console.WriteLine("Aparece um pato bravo");
        }
     
    }
}
