using System;

namespace ClassesD
{
    public class Cavalo : Mamifero, ICorrida
    {
        //Métodos da classe pai
        public override void EmitirSom()
        {
            throw new NotImplementedException();
        }

        public override void Mover()
        {
            throw new NotImplementedException();
        }
        
        //Métodos da Interface
        public void Aceleracao()
        {
            throw new NotImplementedException();
        }

        public void Parar()
        {
            throw new NotImplementedException();
        }

        public void Velocidade()
        {
            throw new NotImplementedException();
        }
    }
}