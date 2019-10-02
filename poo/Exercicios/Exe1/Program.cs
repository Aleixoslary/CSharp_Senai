// Criar um programa que leia um aluno. Crie uma classe aluno com as seguintes
// propriedades: Nome, Curso, Idade, RG, Bolsista (boolean).

using System;
using Exe1.Controllers;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
           AlunoController Pessoa = new AlunoController();
           Console.Clear();
           Pessoa.LerAluno();
           Pessoa.ExibirAluno();
        }
    }
}
