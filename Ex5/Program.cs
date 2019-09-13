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
