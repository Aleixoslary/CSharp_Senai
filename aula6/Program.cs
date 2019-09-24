using System;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BomDia("Qualquer coisa"));
            
            //Não precisa de Console.WriteLine, pois ela é tipo Void e não tem return; 
            ImprimeDataHora();

            //chamamos a função que calcula a média
            double[] numeros = {2,5,2,8,9,5};

            Console.WriteLine(CalculaMedia(numeros));
           
            Console.WriteLine(Soma(numeros));


        }

                                    //Funções são declaradas no class Program, pq o Main é uma função;
                                    //ToUpper converte tudo para MAIÚSCULA;

        /// <summary>
        /// Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>"Acordei e não recomendo!"</returns>
        static string BomDia(){
        return "Acordei e não recomendo!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com horário</returns>
        static string BomDia(string saudacao){
            int hora =DateTime.Now.Hour;

            if (hora <12){
                saudacao= "Acordei e não recomendo";

            } else if (hora>=12 && hora <=18){
                saudacao="Hora do almoço :)";
            } else{
                saudacao="Bora dormir";
            }

        return saudacao;
        }

        /// <summary>
        /// retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia(int numero){
        return numero;
        }

        /// <summary>
        /// Retorna Data e hora atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }

        /// <summary>
        ///  Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia(double[] valores){

            double resultado=0;
            
            for (int i=0; i<valores.Length; i++){

                resultado=resultado+valores[i];
            }

            resultado=resultado/valores.Length;

        return resultado;
        }

        static double Soma(double[] valores){
            double resultado=0;
            for(int i=0; i<valores.Length;i++){
                resultado=resultado+valores[i];
            }

        return resultado;
        }

    }
}
