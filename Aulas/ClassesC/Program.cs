using System;
using System.Reflection;

namespace ClassesC
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario("a", 29, 1999.99, "Gerente");
            Aluno a = new Aluno("b", 18, 20190324, 3010);

            getValores(f);

            Console.ReadKey();
        }

        static void getValores(object obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (var p in props)
                Console.WriteLine(p.Name + ": " + p.GetValue(obj));
        }
    }

    abstract class Pessoa
    {
        string nome;
        int idade;

        public Pessoa(string n, int i)
        {
            this.Nome = n;
            this.Idade = i;
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }
    }

    class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string n, int i, double s, string c) : base(n, i)
        {
            this.Salario = s;
            this.Cargo = c;
        }
    }

    class Aluno : Pessoa
    {
        public int Turma { get; set; }
        public int Matricula { get; set; }

        public Aluno(string n, int i, int m, int t) : base(n, i)
        {
            this.Matricula = m;
            this.Turma = t;
        }
    }
}
