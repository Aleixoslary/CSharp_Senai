
// Faça um algoritmo para solicitar ao
// usuário um número, calcular e mostrar o seu triplo.
using System;

namespace Exercicios_aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int resultado;

            Console.WriteLine("Digite um número:");

            num1 = int.Parse(Console.ReadLine());

            resultado = num1*3;

            Console.WriteLine($"O triplo de {num1} é {resultado}");


        }
    }
}
