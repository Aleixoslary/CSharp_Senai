// O preço do vale transporte é de R$4,30. O motorista de um ônibus deseja
// adquirir um programa que leia a quantidade de passageiros que entram no
// ônibus e que depois calcule e escreva quanto de dinheiro ele terá arrecadado.
// Considere que todos os passageiros irão pagar o vale transporte sem
// descontos.

using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado;
            int  passageiros;

            Console.WriteLine("Qual a quantidade de passageiros?");
            passageiros= int.Parse(Console.ReadLine());

            resultado= passageiros*4.30f;

            Console.WriteLine($"O valor total arrecadado é R${resultado}");
        }
    }
}
