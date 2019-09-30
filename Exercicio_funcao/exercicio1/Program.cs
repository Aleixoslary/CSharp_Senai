
// // Criar uma função do tipo double que recebe como argumentos valor e porcentagem, onde o 
// intuito é atribuir um desconto sobre a porcentagem e retornar
// o valor aplicado o desconto

using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.Write("Digite o valor: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem do desconto: ");
            double c = double.Parse(Console.ReadLine().Replace("%", ""));

            Console.WriteLine(Desconto(b,c));

            }catch(Exception){
                System.Console.WriteLine("Os dados devem ser númericos");
            }
        }

        //FUNÇÃO QUE  CALCULA DESCONTO EM VALORES
         /// <summary>
         /// Aplica desconto em  algum valor
         /// </summary>
         /// <param name="valor">valor sem desconto</param>
         /// <param name="porcento">percentual de desconto</param>
         /// <returns>Valor com desconto</returns>
        static double Desconto(double valor,double porcento){
        double resultado;
            resultado =valor-(valor*(porcento/100));
        return resultado;
        }
    }
}
