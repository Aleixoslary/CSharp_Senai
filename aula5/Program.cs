using System;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];
            string sair="";

            while (sair!="0"){
                Console.WriteLine("\nBem vindo ao nosso Sistema\n\n          MENU\n1- Cadastrar Passagem\n2- Listar Passagens\n0- Sair");
                 sair= Console.ReadLine();

                switch(sair){

                    case "1":
                        for (int i=0; i<=4; i++){
                            Console.Write("Entre com o nome do passageiro: ");
                            nome[i]=Console.ReadLine();

                            Console.Write("Qual a UF origem? ");
                            origem[i]=Console.ReadLine();

                            Console.Write("Qual a UF destino? ");
                            destino[i]=Console.ReadLine();

                            Console.Write("Qual a data de ida? ");
                            data_ida[i]=DateTime.Parse(Console.ReadLine());

                            Console.Write("Qual a data de volta? ");
                            data_volta[i]=DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Dados cadastrados com sucesso!!!");
                        }
                        
                    break;

                    case "2":
                        for (int i=0; i<=4; i++){
                            if (nome[i]!= "" && origem[i]!="" && destino[i]!="" && data_ida[i]!=null && data_volta[i]!=null){
                                Console.WriteLine();
                                Console.WriteLine($"Passagem Nº {i+1}");
                                Console.WriteLine(nome[i]);
                                Console.WriteLine(origem[i]);
                                Console.WriteLine(destino[i]);
                                Console.WriteLine(data_ida[i]);
                                Console.WriteLine(data_volta[i]);
                                Console.WriteLine();

                            }

                            //  Console.WriteLine($"{Nome: nome[i]} |Origem: {origem[i]} |Destino {destino[i]} |Data ida: {data_ida[i]} |Data {data_volta[i]}");
                        }
                    break;
                    
                    case "0":
                        Console.Write("Obrigado por escolher nosso sitema");
                    break;

                    default:
                         Console.Write("Opção inválida");
                    break;
                }
            }
        }
    }
}
