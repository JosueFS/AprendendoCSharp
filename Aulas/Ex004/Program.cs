using System;
using System.IO;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe seu numero: ");
            string telefone = Console.ReadLine();

            StreamWriter texto = File.AppendText("arquivo.csv");
            texto.WriteLine(nome + "; " + telefone);
            texto.Close();
            Console.WriteLine("Registro Concluido!");

            Console.ReadKey();
        }
    }
}
