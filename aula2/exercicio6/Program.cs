using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade =0;

            Console.WriteLine("Qual sua idade? ");
            idade=int.Parse(Console.ReadLine());

            if (idade<3){
                Console.WriteLine($"{idade} Você ainda não tem idade para jogar :(");
            } else if (idade>=3 && idade<6){
                Console.WriteLine($"{idade} APTO PARA: EARLY CHILDHOOD");
            } else if (idade >=6 && idade <10){
                Console.WriteLine($"{idade} APTO PARA: EARLY CHILDHOOD, EVERYONE");
            } else if (idade>=10 && idade <13){
                Console.WriteLine($"{idade} APTO PARA: EARLY CHILDHOOD, EVERYONE, EVERYONE 10+");
            } else if (idade >=13 && idade <17){
                Console.WriteLine($"{idade} APTO PARA: EARLY CHILDHOOD, EVERYONE, EVERYONE 10+, TEEN");
            } else if (idade>=17) {
                Console.WriteLine($"{idade} APTO PARA: EARLY CHILDHOOD, EVERYONE, EVERYONE 10+, TEEN, MATURE.");
            } else if (idade>=18){
                Console.WriteLine($"{idade} APTO PARA TODAS AS CATEGORIAS: EARLY CHILDHOOD, EVERYONE, EVERYONE 10+, TEEN, MATURE, ADULTS ONLY");
            }
        }
    }
}