using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] num=new int[10];
           int r=0;

           for(int i=0; i<=9;i++){
               Console.WriteLine("Digite um número: ");
               num[i]=int.Parse(Console.ReadLine());

              r=num[9]*5;
           }
            Console.WriteLine($"Útilma posição {num[9]} * 5 é {r}");
        }
    }
}
