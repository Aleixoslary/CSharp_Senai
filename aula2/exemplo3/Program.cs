using System;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deixando declarada a variavel como falsa por padrão;
            bool entrada =false;
            int idade;
            string retorno;

            Console.Write("Digite sua idade");
            idade= int.Parse(Console.ReadLine());

            //Como já atribuimos anteriormente, mudamos o estado da váriavel
            //para verdadeira caso entre nesta condição:
            if (idade>17){
                entrada = true;
            }

            if (entrada == true){
                retorno="Entrada Permitida! :)";
            } else
            {
                retorno="Entrada não permitida! :(";
            }

            Console.WriteLine(retorno);


        }
    }
}
