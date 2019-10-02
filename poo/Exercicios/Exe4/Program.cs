// // Crie uma classe Calculadora que faça as quatro operações básicas (soma,
// subtração, multiplicação e divisão). Crie uma classe derivada
// CalculadoraCientifica que, além das operações básicas, faça cálculos de
// potência;
using System;
using Exe4.Controllers;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
        //    CalculadoraController cal1 = new CalculadoraController();

           CientificaController cal1 = new CientificaController();

           System.Console.WriteLine(" 1) Calculadora 2) Calculadora Científica");
           string opcao = Console.ReadLine();

           switch(opcao){
               case "1":
               cal1.Calculadora();
               break;

               case"2":
               cal1.Potencia();
               break;
               
               default:
               System.Console.WriteLine("Opção inválida");
               break;
           }
        }
    }
}
