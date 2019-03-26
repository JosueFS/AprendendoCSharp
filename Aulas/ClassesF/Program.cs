using System;

//Toda classe deriva da classe Object
namespace ClassesF
{
    class Program : Teste
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            Teste t2 = t;
            
            Console.WriteLine(t.Equals(t));
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(t2.GetHashCode());
            Console.WriteLine(t.GetType());
            Console.WriteLine(t.ToString());

            Console.ReadKey();
        }
    }
}
