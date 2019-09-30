using System;

using atividade_poo.obj.Models;

namespace atividade_poo.Controllers
{
    public class AlunoController
    {
        AlunoModel al = new AlunoModel ();
           //Comportamentos
        /// <summary>
        /// Começar a estudar
        /// </summary>
        public void Estudar(){
           Console.WriteLine("Estou estudando!!");
        }

        /// <summary>
        /// Pedir intervalo
        /// </summary>
        public void PedirIntervalo(){
            System.Console.WriteLine("Pode fazer intervalo aeeee!");
            System.Console.WriteLine("QUERO CAFÉÉÉÉ!");
        }
        
        /// <summary>
        /// Pedir Ajuda
        /// </summary>
        public void PedirAjuda(){
            System.Console.WriteLine("Somebody save meeee");
        }

        /// <summary>
        /// Cadastro de aluno
        /// </summary>
        public void CadastrarAluno(){
            System.Console.WriteLine("Insira seu nome: ");
            al.Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o seu curso:");
            al.Curso = Console.ReadLine();

            System.Console.WriteLine("Insira seu RA:");
            al.Ra = Console.ReadLine();

           System.Console.WriteLine("Insira sua idade");
           al.Idade=int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Exibir cadastro de aluno
        /// </summary>
        public void ExibirAluno(){
            System.Console.WriteLine("Nome: " + al.Nome);
            System.Console.WriteLine("Curso: " + al.Curso);
            System.Console.WriteLine("RA: " + al.Ra);
            System.Console.WriteLine("Idade: " + al.Idade);
        }
    }
}