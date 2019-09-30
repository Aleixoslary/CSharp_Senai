// Faça um algoritmo que leia três números inteiros e retorne o maior valor lido.

using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,n3;

            Console.WriteLine("Digite o primeiro número");
            n1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite terceiro número");
            n3= int.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3) {
                 Console.Write($"{n1} é o maior");
             } else if (n2>n1 && n2>n3){
                Console.Write($"{n2} é o maior");
             } else {
                 Console.Write($"{n3} é o maior");
             }
        }
    }
}

