// Escreva um algoritmo que leia o nome de um vendedor, o seu salário fixo e o
// total de vendas efetuadas por ele no mês (em dinheiro). O vendedor ganha 10%
// de comissão sobre suas vendas efetuadas. Exiba, o nome, o salário fixo e salário
// final do mês do vendedor.

using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
           string nomeVendedor;
           float salario, totalVendas, resultado;

           Console.WriteLine("Digite seu Nome");
           nomeVendedor = Console.ReadLine();

           Console.WriteLine("Digite o salário");
           salario=float.Parse(Console.ReadLine());

           Console.WriteLine("Digite  o Total de Vendas");
           totalVendas=float.Parse(Console.ReadLine());

           resultado=(totalVendas*0.10f)+salario;

           Console.WriteLine($"{nomeVendedor} seu salário é {salario} e seu salário final é {resultado}");

        }
    }
}
