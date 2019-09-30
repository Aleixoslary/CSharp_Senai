//Criar uma função do tipo void que escreve no console o atual dia da semana usando Datetime

using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           Dia();
        }

        /// <summary>
        /// Função mostra o o dia da semana que estamos
        /// </summary>
        static void Dia(){
            
            System.Console.WriteLine(DateTime.Now.DayOfWeek);
        }

    }
}
