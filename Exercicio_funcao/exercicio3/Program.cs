// Criar uma sobrecarga de métodos chamada MostraInfo onde:
// a) 1 - Sem argumentos, escreve no console a razão social da escola Senai de
// Informática
// b) 2 - Com dois argumentos, retorna seu nome é sobrenome
// c) 3 - Com três argumentos, retorna sua idade, peso e altura

using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Seu nome: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            
            System.Console.WriteLine("Sua idade: ");
            string idade = Console.ReadLine();

            System.Console.WriteLine("Sua peso: ");
            string peso = Console.ReadLine();

            System.Console.WriteLine("Sua altura: ");
            string altura = Console.ReadLine();

             System.Console.WriteLine(MostraInfo());

             System.Console.WriteLine(MostraInfo(nome ,sobrenome));
             
             System.Console.WriteLine(MostraInfo(idade ,peso ,altura));

         
        }
        /// <summary>
        /// Função que mostra razão social, nome, sobrenome, idade, peso, altura
        /// </summary>
        /// <returns>Razão social SENAI</returns>
        static string MostraInfo(){
            return "Serviço Nacional de Aprendizaem Industrial -Escola SENAI de Informática";
        }

        /// <summary>
        /// Função que mostra nome e sobrenome do usuário
        /// </summary>
        /// <param name="nome">Nome do usuário</param>
        /// <param name="sobrenome">Sobrenome do usuário</param>
        /// <returns></returns>
        static string MostraInfo( string nome, string sobrenome){
            return  nome + " " +sobrenome;
        }
        /// <summary>
        /// Função que mostra idade, peso, alura do usuário
        /// </summary>
        /// <param name="idade">Idade usuário</param>
        /// <param name="peso">Peso do usuário</param>
        /// <param name="altura">Altura do usuário</param>
        /// <returns></returns>
        static string MostraInfo( string idade, string peso, string altura){
            return idade + " " +peso + " " +altura;
        }
    }
}
