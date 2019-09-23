using System;

namespace Atividade {
    class Program {
        static void Main (string[] args) {
            string perfil, resultado, menu, menuPerfil, sair, regiao;
            int produto;

            Console.WriteLine ("\nPerfil \n\n Selecione seu perfil.\n\n 1. Comprador \n 2. Produtor\n");
            perfil = Console.ReadLine ();

            switch (perfil) {
                case "1":
                    resultado = "Comprador";
                    break;

                case "2":
                    resultado = "Produtor";
                    break;

                default:
                    resultado = "Opção Inválida!";
                    break;
            }

            if (resultado == "Comprador") {

                Console.WriteLine ("Você logou como comprador.");
                Console.WriteLine ("\nMenu \n\n Selecione uma opção.\n\n 1. Perfil \n 2. Buscar Produtos \n 3. Receitas ");
                menu = Console.ReadLine ();
                if (menu == "1") {
                    Console.WriteLine ("\nEscolha uma ação \n\n 1. Visualizar perfil \n 2. Editar \n 3. Sair");
                    menuPerfil = Console.ReadLine ();
                    if (menuPerfil == "1") {
                        Console.WriteLine ("\nNome:\nE-mail:\nData de Nascimento:\nCPF:\n");
                    } else if (menuPerfil == "2") {
                        Console.WriteLine ("\nNome:\nE-mail:\nData de Nascimento:\nCPF:\n\nEditar Perfil");
                    } else if (menuPerfil == "3") {
                        //string sair;
                        Console.WriteLine ("\nDeseja Sair?\n1. Sim\n2. Não");
                        sair = Console.ReadLine ();
                        if (sair == "1") {
                            Console.WriteLine ("\nVoltando ao menu de login");
                        } else {
                            Console.WriteLine ("\nOperação Cancelada");
                        }
                    }
                } else if (menu == "2") {

                    //Pegar os código e colar
                    //string regiao, min, max;
                    //int produto;
                    Console.WriteLine ("ESCOLHA UMA REGIÃO: \n Zona Norte  \n Zona Leste \n Zona Oeste \n Zona Sul ");
                    regiao = Console.ReadLine ();
                    if (regiao == "")
                    {
                        Console.WriteLine ("Preencha os campos obrigatórios.");
                    } else {
                        switch (regiao) {
                            case "Zona Norte":
                                Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Batata \n 2 - Beterraba \n 3 - Arroz\n 4 - Maçã");
                                produto = int.Parse (Console.ReadLine ());
                                switch (produto) {
                                    case 1:
                                        Console.WriteLine ("PRODUTO: Batata\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 2:
                                        Console.WriteLine ("PRODUTO: Beterraba\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 3:
                                        Console.WriteLine ("PRODUTO: Arroz\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 4:
                                        Console.WriteLine ("PRODUTO: Maçã\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    default:
                                        Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                                break;
                            case "Zona Leste":
                                Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Amendoim \n 2 - Pera \n 3 - Cenoura\n 4 - Cebola");
                                produto = int.Parse (Console.ReadLine ());
                                switch (produto) {
                                    case 1:
                                        Console.WriteLine ("PRODUTO: Amendoim\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 2:
                                        Console.WriteLine ("PRODUTO: Pera\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 3:
                                        Console.WriteLine ("PRODUTO: Cenoura\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 4:
                                        Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    default:
                                        Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                                break;
                            case "Zona Oeste":
                                Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Batata \n 2 - Lixia \n 3 - Banana\n 4 - Cebola");
                                produto = int.Parse (Console.ReadLine ());
                                switch (produto) {
                                    case 1:
                                        Console.WriteLine ("PRODUTO: Batata\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 2:
                                        Console.WriteLine ("PRODUTO: Lixia\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 3:
                                        Console.WriteLine ("PRODUTO: Banana\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 4:
                                        Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    default:
                                        Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                                break;
                            case "Zona Sul":
                                Console.WriteLine ("ESCOLHA UM PRODUTO: \n 1 - Pinha \n 2 - Beterraba \n 3 - Xuxu\n 4 - Cebola");
                                produto = int.Parse (Console.ReadLine ());
                                switch (produto) {
                                    case 1:
                                        Console.WriteLine ("PRODUTO: Pinha\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 2:
                                        Console.WriteLine ("PRODUTO: Beterraba\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 3:
                                        Console.WriteLine ("PRODUTO: Xuxu\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    case 4:
                                        Console.WriteLine ("PRODUTO: Cebola\nQUANTIDADE: 4\nPREÇO UNITÁRIO: R$0,50");
                                        break;
                                    default:
                                        Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine ("Região inválida!");
                                break;
                        }
                    }

                    //Console.WriteLine ("Esperando código");
                } else if (menu == "3") {
                    Console.WriteLine ("\n\n1. Receita de bolo\n2. Receita de Sopa de Macaco\n3. Macaco a milaneza\n\n");
                    string receita;
                    receita = Console.ReadLine ();
                    if (receita == "1") {
                        Console.WriteLine ("\nPreço Médio: R$25\n\nRendimento: 2 porções");
                    } else if (receita == "2") {
                        Console.WriteLine ("\nPreço Médio: R$25\n\nRendimento: 2 porções");
                    } else if (receita == "3") {
                        Console.WriteLine ("\nPreço Médio: R$25\n\nRendimento: 2 porções\n");
                    } else {
                        Console.WriteLine ("\nReceita não cadastrada.");
                    }
                }

            } else if (resultado == "Produtor") {
                Console.WriteLine ("Você logou como produtor.");
                Console.WriteLine ("\nMenu \n\n 1. Perfil\n 2. Cadastrar Produtos \n 3. Produtos Cadastrados\n");

            } else {
                Console.WriteLine ("Opção Inválida!\nDigite uma opção Válida.");
        }

        }
    }
}