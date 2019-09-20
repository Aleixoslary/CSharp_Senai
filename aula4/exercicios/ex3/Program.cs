using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [12];
            string[] cor = new string [12];
            string[] tamanho = new string [12];
            double[] preco = new double[12];

            for(int i=0; i<11;i++){
                Console.Write("Digite o nome do produto: ");
                nome[i]=Console.ReadLine();
            }

            for(int i=0; i<11;i++){
                Console.Write("Digite a cor do produto: ");
                cor[i]=Console.ReadLine();
            }
            for(int i=0; i<11;i++){
                Console.Write("Digite o tamanho do produto[P/M/G/GG]: ");
                tamanho[i]=Console.ReadLine();
            }
            for(int i=0; i<11;i++){
                Console.Write("Digite o tamanho do preço: ");
                preco[i]=double.Parse(Console.ReadLine());
            }
             for(int i=0; i<11;i++){
                 Console.Write($"Nome: {nome[i]} | Cor: {cor[i]} | Tamanho: {tamanho[i]} | Preço: {preco[i]} \n");
             }
        }
    }
}
