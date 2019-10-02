using System;
using Aula12_Poo.Controllers;
using Aula12_Poo.Models;

namespace Aula12_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
           CarroController carro = new CarroController();

           CarroEletricoController carroEletrico = new CarroEletricoController();
                      
           Console.Clear(); //Limpa o terminal
           
           carro.Ligar();
        //    carro.Acelerar();
        //    carro.Frear();
        //    carro.Desligar();
           
        //    carro.CadastrarMotor();

        carroEletrico.CarregaBateria(100);
        carroEletrico.CarregaBateria(15);
        System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());
        }
    }
}
