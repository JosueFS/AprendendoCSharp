using System;

//Sobrecarga de construtores
//Encapsulamento de atributos
namespace ClassesB
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Josué", 27);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Idade);
        }
    }

    class Pessoa
    {
        string nome;
        int idade;

        public Pessoa(string n, int i) {
            Nome = n;
            Idade = i;
        }

        public string Nome{ 
            set {nome = value;}
            get {return nome;}
        }

        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }
    }
}
