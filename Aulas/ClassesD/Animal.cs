using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesD
{
    public abstract class Animal
    {
        public virtual void EmitirSom() {
            Console.WriteLine("Default");
        }

        public virtual void Mover()
        {
            throw new NotImplementedException();
        }
    }
}
