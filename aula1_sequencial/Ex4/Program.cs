// Elabore um algoritmo que efetue a apresentação da conversão de um valor em
// real (R$) para o valor em dólar (US$). O algoritmo deverá solicitar o valor da
// cotação do dólar.

using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real, dolar, cotacao;

            Console.WriteLine("Digite o valor em Reais");
            real= float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a cotacao atual do Dólar?");
            cotacao=float.Parse(Console.ReadLine());

            dolar=real/cotacao;
        
            Console.WriteLine($"O valor em dólares é ${dolar}");

        }
    }
}
