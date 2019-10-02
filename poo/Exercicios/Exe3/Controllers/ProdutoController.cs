using System;
using Exe3.Models;

namespace Exe3.Controllers
{
    public class ProdutoController
    {
        ProdutoModel Produto = new ProdutoModel();
        
        public void CadastroProduto(){
            System.Console.Write("Nome do Produto: ");
            Produto.Nome = Console.ReadLine();
            
            System.Console.Write("Código do Produto: ");
            Produto.Codigo = int.Parse(Console.ReadLine());

            System.Console.Write("Preço do Produto: ");
            Produto.Preco = double.Parse(Console.ReadLine());

            System.Console.Write("Quantidade do Produto: ");
            Produto.Quantidade = int.Parse(Console.ReadLine());
        }

        public void ReservaProduto(){
            System.Console.WriteLine("Deseja reservar produto? SIM / NÃO");
            string resp = Console.ReadLine().ToUpper();

            if (resp =="SIM"){
                Produto.Reserva = true;
            } 
        }

        public void ExibirProduto(){
            System.Console.WriteLine($"Código: {Produto.Codigo} | Produto: {Produto.Nome} | Preço: R${Produto.Preco} | Quantidade: {Produto.Quantidade}");
           
            if (Produto.Reserva == true){
                System.Console.WriteLine("Produto Reservado");
            }else{
                System.Console.WriteLine("Nada foi reservado");
            }
        }
    }
}