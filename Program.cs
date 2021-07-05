using System;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            Pessoa pessoa = new Pessoa();
            Console.Write("Nome da Pessoa: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Ano de Nascimento: ");
            pessoa.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            pessoa.ExibirDados();
            Console.ReadKey();
        }
    }
}
