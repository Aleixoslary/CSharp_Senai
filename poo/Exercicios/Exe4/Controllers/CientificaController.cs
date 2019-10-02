using System;
using Exe4.Models;

namespace Exe4.Controllers
{
    public class CientificaController : CalculadoraController
    {
        CalculadoraModel numero = new CalculadoraModel();
        public void Potencia(){
            System.Console.WriteLine("Digite a base da potência");
            numero.Primeiro = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a potência");
            numero.Segundo = double.Parse(Console.ReadLine());

            numero.Resultado = Math.Pow(numero.Primeiro,numero.Segundo);

            System.Console.WriteLine(numero.Resultado);
        }
    }
}