using System;
using System.IO;
using Exe1.Models;

namespace Exe1.Controllers
{
    public class AlunoController
    {
        AlunoModel Aluno = new AlunoModel();
        public void LerAluno(){
         try{
            Console.WriteLine("Digite seu Nome:");
            Aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu Curso");
            Aluno.Curso = Console.ReadLine();

            Console.WriteLine("Digite sua Idade:");
            Aluno.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu RG:");
            Aluno.RG = Console.ReadLine();

            Console.WriteLine("Você é Bolsista? SIM/NÃO");
            string resp = Console.ReadLine().ToUpper();

                if (resp == "SIM"){
                    Aluno.Bolsista = true;
                    
                } else{
                    Aluno.Bolsista = false;
                    
                }
            System.Console.WriteLine("Cadastro realizado com sucesso.");
            
            }catch (Exception ex){
            System.Console.WriteLine("Algo deu errado! :( Tente novamente");
            SalvarErros(ex);
        }
        }

        public void ExibirAluno(){
            System.Console.WriteLine($"{Aluno.Nome} | {Aluno.Curso} | {Aluno.Idade} | {Aluno.RG}");

            if (Aluno.Bolsista == true){
                System.Console.WriteLine(" Você é Bolsista");
            }else{
                System.Console.WriteLine("Você não é Bolsista");
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