using System;
using Aula11_Poo.Controllers;

namespace Aula11_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutosController produto1 = new ProdutosController();

           produto1.CadastrarProduto();

           produto1.ExibirProduto();
        }
    }
}
