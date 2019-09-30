using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, media;
            string resultado;

            Console.Write("Digite a primeira nota: ");
            nota1= float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2= float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3= float.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3)/3;

            //ESTRUTURA DE REPETIÇÃO SE SENÃO SE;
            if (media >=6){
                resultado = "Aprovado";
            } else if (media<6 && media>=4){
                    resultado="Recuperação";
            } else{
                resultado="Reprovado";
            }

            Console.WriteLine($"Média:{media} - O aluno está {resultado}");



        }      
    }
}
