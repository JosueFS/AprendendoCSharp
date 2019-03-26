using System;


//Polimorfismo
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

            Console.ReadKey();
        }
    }

    


}
