using System;
using Exe2.Models;

namespace Exe2.Controllers
{
    public class CelularController
    {
        CelularModel Celular = new CelularModel();
        public void LigarCel(){
            Celular.Ligar=true;
            System.Console.WriteLine("Celular Ligado :)");
        }

        public void DesligarCel(){
            Celular.Ligar = false;
            System.Console.WriteLine("Celular Desligado :(");
        }

         public void FazerLigacao(){
            if (Celular.Ligar == true){
                System.Console.WriteLine("Fazendo Ligação");
            }else{
                System.Console.WriteLine("Celular Desligado");
            }
        }

        public void MandarMensagem(){
            if (Celular.Ligar == true){
                System.Console.WriteLine("Mandando Mensagem");
            }else{
                System.Console.WriteLine("Celular Desligado");
            }

    }
        public void Menu(){
            if (Celular.Ligar == true){
                string resp;
                System.Console.WriteLine(" Menu\n 1-Ligar\n 2-Mandar Mensagem\n 3-Desligar");
                resp= Console.ReadLine();

                switch (resp){
                    case "1":
                        FazerLigacao();
                    break;
                    case "2":
                        MandarMensagem();
                    break;
                    case "3":
                         DesligarCel();
                    break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }
            }else{
                    System.Console.WriteLine("Celular Desligando");
            }
        }
    }    
}