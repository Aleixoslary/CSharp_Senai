using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int r;

            Console.WriteLine("Digite o número: ");
            num=int.Parse(Console.ReadLine());
            
            for (int cont=1; cont<=10; cont++){
                 r = num * cont;

                Console.WriteLine($"{num} X {cont} = {r}");
            }

        }
    }
}
