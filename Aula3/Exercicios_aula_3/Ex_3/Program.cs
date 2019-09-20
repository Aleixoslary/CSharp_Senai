using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1;
            int num;
            Console.WriteLine("Digite um número: ");
            num=int.Parse(Console.ReadLine());

           do{
               if (cont%5==0){
                   Console.WriteLine($"Os números multiplos de 5 no intervalo de 0 a {num} são {cont}");
               }
                cont++;
           } while (cont<=num);
        }
    }
}


//  do {
//                 Console.Write("Digite um número: ");
//                 num=int.Parse(Console.ReadLine());
//                 if (num%3==0){
//                     acm+=num;
//                 }
//                 cont++;
//             } while(cont<=20);