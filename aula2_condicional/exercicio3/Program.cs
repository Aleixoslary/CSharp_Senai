// Faça um algoritmo que leia dois números inteiros e retorne o maior valor lido.

using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite o primeiro número: ");
            n1= int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2= int.Parse(Console.ReadLine());

            if (n1>n2){
                Console.WriteLine($"{n1} é maior que {n2}");
            } else
            {
                Console.WriteLine($"{n2} é maior que {n1}");
            }
            

        }
    }
}
