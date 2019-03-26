using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesD
{
    class Ave : Animal
    {
        //SobreEscrita do método
        public new void EmitirSom()
        {
            Console.WriteLine("Piu, Piu");
        }
    }
}
