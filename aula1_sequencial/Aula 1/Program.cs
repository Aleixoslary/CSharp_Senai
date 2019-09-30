using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somente declaramos, sem atribuir valor;
            int num1;

            //declaramos atribuindo um valor;
            int num2= 5;

            //Declaramos diversar variáveis do mesmo tipo e valor;
            int num3, num4, num5;

            //variável do tipo decimal (real);
            float media;

            //variável do tipo lógico;
            bool resultado= false;
            
            //Variavel do tipo texto (caracter);
            string nomeAluno;

            //QUEBRA A LINHA;
            Console.WriteLine();

            //ESCREVE NA LINHA QUEBRANDO-A;
            Console.WriteLine("Bem-Vindos à nosssa primeira aplicação");

            //ESCREVE UMA LINHA;
            Console.Write("Digite o nome do Aluno:");

            //CAPTURA O DADO DIGITADO  PELO USUÁRIO E SALVO NA VARIÁVEL;
            nomeAluno= Console.ReadLine();


            //CONCATENAÇÃO;
            Console.WriteLine(nomeAluno +", Digite a primeira nota");
            //CONVERTE  O TEXTO CAPTURADO PARA INTEIRO;
            num3= int.Parse(Console.ReadLine());
            //INTERPOLAÇÃO -- CHAMAR A VARIAVEL EM QUALQUER LUGAR DA FRASE;
            Console.WriteLine($"Sua primeira note é {num3}");


            //SEGUNDA NOTA
            Console.WriteLine("Digite sua segunda nota:");
            num4= int.Parse(Console.ReadLine());

            //TERCEIRA NOTA
            Console.WriteLine("Digite sua terceira nota:");
            num5= int.Parse(Console.ReadLine());

            media= (num3+ num4+num5)/3;

            Console.WriteLine($"Sua média é {media}");
       }
    }
}


//WRITE = SAÍDA
//READ = ENTRADA