using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa, resultado;

            Console.Write("Digite seu sálario ");
            salario=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de despesas ");
            despesa=float.Parse(Console.ReadLine());

            resultado=(salario-despesa);

            if (resultado > 0 ){
                Console.WriteLine($"{resultado} Saldo final Positivo");
            } else{
                Console.WriteLine($"{resultado} Saldo final Negativo");
            }


        }
    }
}
