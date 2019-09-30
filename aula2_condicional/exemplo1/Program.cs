using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO A VARIAVEL
            double nota1, nota2, nota3, media;

            Console.Write("Digite nota 1: ");
            nota1= double.Parse(Console.ReadLine());

            Console.Write("Digite nota 2: ");
            nota2= double.Parse(Console.ReadLine());

            Console.Write("Digite nota 3: ");
            nota3= double.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3)/3;

            if (media>=6){
                Console.WriteLine("Aluno Aprovado!");
            } else{
               Console.WriteLine("Aluno Reprovado:");
            }
        }
    }
}
