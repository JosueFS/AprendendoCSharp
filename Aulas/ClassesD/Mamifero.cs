using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesD
{
    class Mamifero : Animal
    {
        //SobreEscrita do método
        public new void EmitirSom()
        {
            Console.WriteLine("Au, Au, Au");
        }
    }
}
