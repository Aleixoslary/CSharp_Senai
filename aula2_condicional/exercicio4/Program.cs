﻿// Se o preço total a ser pago ficar entre 100 e 1000, então forneça um desconto
// de 15%.

using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float precoTotal,resultado;

            Console.Write("Digite o valor total: ");
            precoTotal = float.Parse(Console.ReadLine());

            resultado = precoTotal;

            if (precoTotal>=100 && precoTotal <=1000){

                resultado= precoTotal-(precoTotal*0.25f);
            } 

             Console.WriteLine($"O valor total é {resultado}");
        }
    }
}
