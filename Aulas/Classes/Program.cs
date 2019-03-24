using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            carro c = new carro();
            c.ano = 1997;
            c.cor = "Preto";
            c.modelo = "Ford Focus";
            c.propriedades();
            Console.WriteLine(c.modelo);

            Console.ReadKey();
        }
    }
    class carro
    {
        public string cor;
        public string modelo;
        public int ano;

        public void propriedades()
        {
            Console.WriteLine("teste");
        }

    }
}
