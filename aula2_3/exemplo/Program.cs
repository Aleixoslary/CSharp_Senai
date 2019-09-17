using System;

namespace aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string resultado;
            string final;

            Console.Write("Digite a placa do carro: ");
            placa = Console.ReadLine();

            //CONTAMOS A QUANTIDADE DE CARACTERES DE UM ELEMENTO;
            int caracteres = placa.Length;

            //PEGAMOS O ULTIMO DIGITO COM METODO SUBSTRING();
            final=placa.Substring(caracteres-1);

            if (final=="1" || final=="2"){
                resultado="if/else- O rodízio é na Segunda-Feira";
            } else if (final=="3" || final=="4"){
                resultado="if/else- O rodízio é na Terça-Feira";
            } else if (final=="5" || final=="6"){
                resultado="if/else- O rodízio é na Quarta-Feira";
            } else if (final=="7" || final=="8"){
                resultado="if/else- O rodízio é na Quinta-Feira";
            } else if (final=="0" || final =="9"){
                resultado="if/else- O rodízio é na Sexta-Feira";
            } else{
                resultado="if/else- PLACA INVÁLIDA";
            }

            Console.WriteLine(resultado);

            switch(final){
                case "1":
                resultado="Switch - Segunda-Feira";
                break;
                case "2":
                resultado="Switch - Segunda-Feira";
                break;
                case "3":
                resultado="Switch - Terça-Feira";
                break;
                case "4":
                resultado="Switch - Terça-Feira";
                break;
                case "5":
                resultado="Switch - Quarta-Feira";
                break;
                case "6":
                resultado="Switch - Quarta-Feira";
                break;
                case "7":
                resultado="Switch - Quinta-Feira";
                break;
                case "8":
                resultado="Switch - Quinta-Feira";
                break;
                case "9":
                resultado="Switch - Sexta-Feira";
                break;
                case "0":
                resultado="Switch - Sexta-Feira";
                break;

                default:
                resultado="Switch - Entrada inválida";
                break;
            }
             Console.WriteLine(resultado);

        }
    }
}
