using System;

namespace FuncoesB
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = metodo(1, 2);

            c = metodo();
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static int metodo(int a, int b)
        {
            return a + b;
        }

        //Sobrecarga
        static int metodo()
        {
            return 0;
        }
    }
}
