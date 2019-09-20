using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont=1;
            int num;
            int acm=0;

            do {
                Console.Write("Digite um número: ");
                num=int.Parse(Console.ReadLine());
                if (num%3==0){
                    acm+=num;
                }
                cont++;
            } while(cont<=20);

            Console.WriteLine($"A soma dos múltiplos de três são {acm} e o total é de {cont}");
        }
    }
}
