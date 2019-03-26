using System;

namespace ClassesD
{
    public class Carro : Veiculo, ICorrida
    {
        public override void Mover()
        {
            throw new NotImplementedException();
        }

        public override void Parar()
        {
            throw new NotImplementedException();
        }

        //Métodos da Interface
        public void Aceleracao()
        {
            throw new NotImplementedException();
        }

        void ICorrida.Parar()
        {
            throw new NotImplementedException();
        }

        public void Velocidade()
        {
            throw new NotImplementedException();
        }
    }
}