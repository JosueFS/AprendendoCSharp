using System;
using System.IO;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um novo Arquivo
            //TextWriter texto = new StreamWriter("arquivo.txt");
            //texto.WriteLine("Text ; AA");
            //texto.WriteLine("Text ; AB");
            //texto.Close();

            //Abre um arquivo existente para alteração
            //StreamWriter texto = File.AppendText("arquivo.txt");
            //texto.WriteLine("Nova linha");
            //texto.Close();


            //Faz a leitura de um arquivo
            TextReader textoR = new StreamReader("arquivo.txt");
            Console.WriteLine(textoR.ReadLine());
            Console.WriteLine(textoR.ReadLine());
            Console.WriteLine(textoR.ReadLine());
            textoR.Close();

            Console.ReadKey();
        }
    }
}
