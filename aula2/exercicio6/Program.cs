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
                Console.WriteLine($"{idade} EARLY CHILDHOOD - O conteúdo destina-se a crianças pequenas.");
            } else if (idade >=6 && idade <10){
                Console.WriteLine($"{idade} EVERYONE - O conteúdo é geralmente adequado para todas as idades.");
            } else if (idade>=10 && idade <13){
                Console.WriteLine($"{idade} EVERYONE 10+ - O conteúdo é geralmente adequado para todas as idades.");
            } else if (idade >=13 && idade <17){
                Console.WriteLine($"{idade} TEEN - Conteúdo é geralmente adequado para idades 13 e acima.");
            } else if (idade>=17) {
                Console.WriteLine($"{idade} MATURE- Conteúdo é geralmente adequado para idades 17 e acima.");
            } else if (idade>=18){
                Console.WriteLine($"{idade} ADULTS ONLY- Conteúdo adequado somente para adultos maiores de 18 anos.");
            }
        }
    }
}
