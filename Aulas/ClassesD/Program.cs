using System;


//Polimorfismo
namespace ClassesD
{
    class Program
    {
        static void Main(string[] args)
        {
            Ave a = new Ave();
            a.emitirSom();

            Mamifero m = new Mamifero();
            m.emitirSom();

            Console.ReadKey();
        }
    }

    


}
