using System;

namespace ClassesE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não-Estática ou Classe de Instância: Precisam ser instanciadas.
            //Cada instância tem seu próprio atributo e próprio método(Desde que esses atributos e métodos não sejam estáticos também).
            //É acessado através do nome atribuido à variável.(atributo/método).
            ClasseNonStatic c = new ClasseNonStatic
            {
                nome = "João S.",
                idade = 12
            };

            ClasseNonStatic c2 = new ClasseNonStatic
            {
                nome = "Maria S.",
                idade = 13
            };

            //Estática: Não é possível instanciar uma classe estática.
            //Os atributos da classe são como variáveis globais e pode ter seu valor alterado em qualquer parte do programa (Desde que feito da maneira correta).
            //Métodos estáticos não pode ser sobrescritos
            ClasseStatic.nome = "John S.";
            ClasseStatic.idade = 21;

            //Os valores anteriores são substituidos
            ClasseStatic.nome = "Mary S.";
            ClasseStatic.idade = 31;

            Console.WriteLine(c.nome + ", " + c.idade + " Anos.");
            Console.WriteLine(c2.nome + ", " + c2.idade + " Anos.");
            Console.WriteLine(ClasseStatic.nome + ", " + ClasseStatic.idade + " Anos.");
            Console.WriteLine(ClasseStatic.nome + ", " + ClasseStatic.idade + " Anos.");

            Console.ReadKey();
        }
    }
}
