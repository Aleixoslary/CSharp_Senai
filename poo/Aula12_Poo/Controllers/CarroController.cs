using System;
using Aula12_Poo.Models;

namespace Aula12_Poo.Controllers
{
    public class CarroController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void Ligar(){
            carro.Ligado = true;
            System.Console.WriteLine("Ligando carro");
        }
        public void Desligar(){
            carro.Ligado = false;
            System.Console.WriteLine("Desligando carro");
        }
        public void Acelerar(){
            
                if(carro.Ligado == true){
                System.Console.WriteLine("Carro Acelerando");
            } else{
                System.Console.WriteLine("Impossível acelerar, carro desligado!");
            }
        }
        public void Frear(){
            
                if(carro.Ligado == true){
                System.Console.WriteLine("Carro freando");
            } else{
                System.Console.WriteLine("Impossível frear, carro desligado!");
            }
        }

        public void CadastrarMotor(){
          System.Console.WriteLine("Insira quantos cavalos tem o carro: ");
          motor.Cavalos = int.Parse(Console.ReadLine());

          System.Console.WriteLine("Insira quantos cilindros tem o carro: ");
          motor.Cilindros = int.Parse(Console.ReadLine());

          System.Console.WriteLine("Insira o modelo de Pistão tem o carro: ");
          motor.Pistao = Console.ReadLine();

          System.Console.WriteLine("Informações cadastradas com sucesso.");
        }

    }
}