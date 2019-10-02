// Crie um programa que leia produtos e dentro deste produto, crie um método
// que reserve este produto. **Dando dicas: Será necessário utilizar um valor
// booleano.

using System;
using Exe3.Controllers;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController Produto1 = new ProdutoController();

            Console.Clear();

            Produto1.CadastroProduto();
            Produto1.ReservaProduto();
            Produto1.ExibirProduto();
        }
    }
}
