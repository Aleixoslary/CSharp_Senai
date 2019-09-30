using System;
using Exercicio1.Controllers;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaController pessoa1 = new PessoaController(); 

            pessoa1.CadastrarPessoa();
            pessoa1.MostraCategoria();
        }
    }
}
