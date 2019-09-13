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
