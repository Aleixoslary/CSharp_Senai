using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a= new int[10];
           int[] b= new int[10];
           int[] c= new int[10];

           for (int i=0; i<=9; i++){
               Console.Write($"Digite o {i+1}º um número: ");
               a[i]=int.Parse(Console.ReadLine());
           }

            for (int i=0; i<=9; i++){
              Console.Write($"Digite o {i+1}º um número: ");
               b[i+10]=int.Parse(Console.ReadLine());
           }

            for (int i=0; i<=9; i++){
                c[i]= a[i] + b[i];

            }

            for (int i=0; i<=9; i++){
               Console.WriteLine(c[i]);
           }


        }
    }
}
