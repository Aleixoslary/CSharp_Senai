using System;
using System.IO;
using Exercicio1.Models;

namespace Exercicio1.Controllers
{
    public class PessoaController
    {
        PessoaModel Pessoa = new PessoaModel();

        public void CadastrarPessoa(){

           try{
               Console.WriteLine("Digite seu Nome:");
                Pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite sua Idade:");
                Pessoa.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Peso:");
                Pessoa.Peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua Altura:");
                Pessoa.Altura = double.Parse(Console.ReadLine());
           } catch(Exception ex){
                   System.Console.WriteLine("Algo deu errado! :( Tente novamente");
                    SalvarErros(ex);
           }
        }

        public void MostraCategoria() {
            
            Pessoa.Imc = Pessoa.Peso / Math.Pow(Pessoa.Altura,2);

            if (Pessoa.Imc <=18.5){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Abaixo do peso");
            } else if (Pessoa.Imc >18.5 && Pessoa.Imc<=25){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Peso normal");

            }else if (Pessoa.Imc >26 && Pessoa.Imc <=30){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Sobrepeso");
            }else if (Pessoa.Imc >31 && Pessoa.Imc <=35){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Obesidade grau I");
            }else if (Pessoa.Imc >36 && Pessoa.Imc <=39){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Obesidade grau II");
            } else if (Pessoa.Imc >=40){
                System.Console.WriteLine($"{Pessoa.Nome} | {Pessoa.Idade} | IMC: {Pessoa.Imc} \n Obesidade grau III");
            }else{
                System.Console.WriteLine("Não foi possível calcular seu IMC.Tente novamente");
            }
        }
        private void SalvarErros (Exception ex){
            StreamWriter txt = new StreamWriter("Error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());            
            txt.WriteLine(ex);            
            txt.WriteLine();

            txt.Close();
        }
    }
}