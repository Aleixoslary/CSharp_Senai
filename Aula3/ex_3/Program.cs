using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont,quant=0,idade;

            for(cont=1;cont<=10; cont++){
                Console.WriteLine("Digite a idade: ");
                idade=int.Parse(Console.ReadLine());

                if (idade >=50){
                    quant= quant+1;
                }
            }
            Console.WriteLine($"São {quant} com idade igual e acima de 50 anos");

        }
    }
}
