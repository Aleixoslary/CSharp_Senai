using System;
using Exe4.Models;

namespace Exe4.Controllers
{
    public class CalculadoraController
    {
        CalculadoraModel numero = new CalculadoraModel();

        public void Calculadora(){
            System.Console.WriteLine("Digite o primeiro número");
            numero.Primeiro = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo número");
            numero.Segundo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Selecione o operador:\n 1- Soma (+)\n 2- Subtração (-)\n 3- Multiplicação (*)\n 4- Divisão(/)");
            string op = Console.ReadLine();

            switch (op){
                case "1":
                numero.Resultado = numero.Primeiro + numero.Segundo;

                System.Console.WriteLine(numero.Resultado);
                break;
            
              case "2":
                numero.Resultado = numero.Primeiro - numero.Segundo;

                System.Console.WriteLine(numero.Resultado);
                break;

              case "3":
                numero.Resultado = numero.Primeiro * numero.Segundo;

                System.Console.WriteLine(numero.Resultado);
                break;

              case "4":
                if (numero.Segundo == 0){
                    System.Console.WriteLine("Não existe divisão por 0");
                }else{
                    numero.Resultado = numero.Primeiro / numero.Segundo;
                }
                     System.Console.WriteLine(numero.Resultado);
                break;
                
                default:
                    System.Console.WriteLine("Valor inválido");
                break;
            }
            
        }
        
    }
}