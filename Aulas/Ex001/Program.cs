using System;

//Tabuada dos numeros de 0 a 10
namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
               Console.WriteLine("********ã******************************************************");
            }
            Console.ReadKey();
        }
    }
}

