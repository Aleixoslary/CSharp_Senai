using System;

namespace aula8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRY {} CATCH{} TRATA ERROS, ELIMINANDO-OS;
            //EX - Variavel que mostra qual erro está dando no código;

            int numero;

            //escrevemos um bloco de código;
            try{
                Console.WriteLine("Digite um número: ");
                numero=int.Parse(Console.ReadLine());
            }catch(Exception ex){
                
                //mostramos a exceção da regra
                //erro gerado na aplicação;
                Console.WriteLine("Ops... :( Deu merda.Erro" + ex);
            }
        }
    }
}
