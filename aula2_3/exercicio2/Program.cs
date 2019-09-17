using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           float peso, pesoPlan;
           int num;

           Console.Write("Qual seu peso? ");
           peso= float.Parse(Console.ReadLine());

           Console.Write("\n======================\nESCOLHA SEU PLANETA \n\n 1- Mercúrio G=0,37\n 2- Vênus    G=0,88\n 3- Marte    G=0,38\n 4- Júpiter  G=0,2,64\n 5- Saturno  G=1,15\n 6- Urano    G=0,1,17\n======================\n");

           Console.Write("Digite um número de 1 a 6: ");
           num= int.Parse(Console.ReadLine());

           switch (num){
               case 1:
               pesoPlan=(peso/10)*0.37f;
               Console.WriteLine($"Seu peso em Mercúrio é {pesoPlan}");
               break;
               case 2:
               pesoPlan=(peso/10)*0.88f;
               Console.WriteLine($"Seu peso em Vênus é {pesoPlan}");
               break;
               case 3:
               pesoPlan=(peso/10)*0.38f;
               Console.WriteLine($"Seu peso em Marte é {pesoPlan}");
               break;
               case 4:
               pesoPlan=(peso/10)*2.64f;
               Console.WriteLine($"Seu peso em Júpiter é {pesoPlan}");
               break;
               case 5:
               pesoPlan=(peso/10)*1.15f;
               Console.WriteLine($"Seu peso em Saturno é {pesoPlan}");
               break;
               case 6:
               pesoPlan=(peso/10)*1.17f;
               Console.WriteLine($"Seu peso em Urano é {pesoPlan}");
               break;

               default:
               Console.Write("Número inválido, digite um número de 1 a 6");
               break;
           }
        }
    }
}
