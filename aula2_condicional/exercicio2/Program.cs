// Criar um algoritmo que, se o preço total a ser pago for inferior a R$ 100, então
// subtraia R$25,00 do preço total.

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
