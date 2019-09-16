using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          float precoTotal, resultado;

          Console.WriteLine("Digite o preço total: ");
          precoTotal = float.Parse(Console.ReadLine());

            resultado = precoTotal;

          if (precoTotal>100){
              resultado = precoTotal-25f;
          }

          if (resultado<25) {
              resultado=0;
          }
    
          Console.WriteLine($"O valor total é {resultado}");
        }
    }
}
