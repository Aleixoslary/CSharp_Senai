using System;

namespace exerccio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string lanche, num;

            Console.Write("Digite o número do lanche: ");
            lanche=Console.ReadLine();

            switch (lanche){
                case "1":
                num="Hamburguer";
                break;
                case "2":
                num="Cheese Salada";
                break;
                case "3":
                num="Cheese Burguer";
                break;
                case "4":
                num="Cheese Bacon";
                break;

                default:
                num="Não temos essa opção de lanche";
                break;
            }
            Console.WriteLine(num);
        }
    }
}
