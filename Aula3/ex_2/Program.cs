using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
          int cont;
          float alt,ac=0;
          string nome;

          for (cont=1; cont <=15;cont++){
              Console.Write("Digite seu nome: ");
              nome=Console.ReadLine();

              Console.Write("Digite a altura: ");
              alt=float.Parse(Console.ReadLine());

              ac= ac+alt;
            }
            
        ac= ac/15;
        
        Console.Write($"A média de altura é {ac}");
        }
    }
}
