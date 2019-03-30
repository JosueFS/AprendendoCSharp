using System;
using System.Collections.Generic;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> t = new List<string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    t.Add("A" + i);
            //    Console.WriteLine(t[i]);
            //}

            //t.Add(t[0]);
            //t.RemoveAt(0);

            //Console.WriteLine(t.IndexOf("A3"));
            //Console.WriteLine("==================================================");
            //for (int i = 0; i < t.Count; i++)
            //{
            //    Console.WriteLine(t[i]);
            //}


            //for (int x = 0; x < 20; x++)
            //{
            //    int i = Teste(0, 6);
            //    Console.WriteLine(i);
            //}

            int i = Teste(0,6);
            int h = Teste(0,6);

            Console.WriteLine(i + ""+ h);


            Console.ReadKey();
        }

        static int Teste(int min, int max)
        {
            int[] g = new int[max];
            for (int x = min; x < max; x++)
            {
                g[x] = x;
            }
            double[] chance = { 0.40, 0.26, 0.15, 0.10, 0.06, 0.03 };
            Random sorteado = new Random();
            double s = sorteado.NextDouble();
            double fix = 0;

            for (int n = min; n < max; n++)
            {
                fix += chance[n];
                if (s <= fix)
                {
                    return g[Array.IndexOf(chance, chance[n])];
                }
            }
            return 100;
        }
    }
}
