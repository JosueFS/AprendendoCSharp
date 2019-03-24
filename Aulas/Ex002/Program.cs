using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = new string[4];
            n[0] = "A";
            n[1] = "B";
            n[2] = "C";
            n[3] = "D";


            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

            Console.ReadKey();
        }
    }
}
