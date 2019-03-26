using System;

//Polimorfismo
//Interfaces
//Palavra reservada 'virtual': permite às subclasses sobrescrever o método
//Palavra reservada 'new': oculta o método na subclasse
//Palavra reservada 'override': sobrescreve um método virtual/abstrato
namespace ClassesD
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave a = new Ave();
            a.EmitirSom();

            Mamifero m = new Mamifero();
            m.EmitirSom();

            Cavalo c = new Cavalo();
            c.EmitirSom();
            

            Console.ReadKey();
        }
    }

    


}
