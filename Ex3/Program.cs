using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float comissao=0.05f, salario,totalVendas,resultado;
            
            Console.WriteLine("Digite o salário");
            salario= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total de vendas");
            totalVendas= float.Parse(Console.ReadLine());

            resultado=(totalVendas*comissao)+salario;
            Console.WriteLine($"Irá receber {resultado}");
      }
    }
}
