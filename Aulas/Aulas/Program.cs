using System;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da aula: ");
            //Call Ex001();
            var aula = Console.ReadLine();
            Console.WriteLine(aula);
            
            //aguarda uma tecla para finalizar o programa
            Console.ReadKey();
        }
    }
}
