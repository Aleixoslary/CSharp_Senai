using System;
using System.IO;
using Aula11_Poo.Models;

namespace Aula11_Poo.Controllers
{
    public class ProdutosController
    {
        ProdutosModel Produto = new ProdutosModel();

        public void CadastrarProduto(){
        
            try{
            Console.WriteLine("Digite o ID do produto:");
            Produto.IdProduto = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Nome do produto:");
            Produto.NomeProduto = Console.ReadLine();

            System.Console.WriteLine("Digite a Descrição do produto:");
            Produto.Descricao = Console.ReadLine();

            System.Console.WriteLine("Digite o Preço do produto:");
            Produto.Preco = double.Parse(Console.ReadLine());

            // System.Console.WriteLine("Digite o ID do Fornecedor:");
            // Produto.Fornecedor.IdFornecedor = int.Parse(Console.ReadLine());

            // System.Console.WriteLine("Digite o Nome do Forncedor");x'x'x'
            // Produto.Fornecedor.NomeFornecedor = Console.ReadLine();

            }catch(Exception ex){
                System.Console.WriteLine("Desculpe :( Houve um erro na aplicacção");
                SalvarErros(ex);
            }
        }

        public void ExibirProduto(){
            System.Console.WriteLine(Produto.IdProduto);
            System.Console.WriteLine(Produto.NomeProduto);
            System.Console.WriteLine(Produto.Descricao);
            System.Console.WriteLine(Produto.Preco);

            // System.Console.WriteLine(Produto.Fornecedor.IdFornecedor);
            // System.Console.WriteLine(Produto.Fornecedor.NomeFornecedor);
        }

        private void SalvarErros (Exception ex){
            StreamWriter txt = new StreamWriter("Error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());            
            txt.WriteLine(ex);            
            txt.WriteLine();

            txt.Close();
        }
    }
}