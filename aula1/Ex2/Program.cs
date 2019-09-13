using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
           float preco;
           float percentual;
           float resultado;
           float valor;
           float soma;

           Console.WriteLine("Digite o percentual de acréscimo");

           valor=float.Parse(Console.ReadLine());

           percentual= valor/100;
           
           Console.WriteLine("Digite o preço de custo");
           
           preco=float.Parse(Console.ReadLine());

           resultado=preco*percentual;

           soma=resultado + preco;

           Console.WriteLine($"O valor é {soma}");
        }
    }
}
