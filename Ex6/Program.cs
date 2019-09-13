using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, divida, resultado;

            Console.WriteLine("Digite seu salário");
            salario= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total das suas dividas");
            divida= float.Parse(Console.ReadLine());

            resultado= salario-divida;

            Console.WriteLine($"Seu salário é de {salario}, seu total de dividas é {divida}, te sobra {resultado}");

        }
    }
}
