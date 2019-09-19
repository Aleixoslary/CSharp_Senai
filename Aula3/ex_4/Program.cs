using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
           int acm=1;
           int cont=1;

           while (acm<=100){
               Console.WriteLine(acm);
               acm= acm+2;

               cont= cont+1;
            }
            Console.WriteLine($"O total de números impares é {cont}");
        }
    }
}
