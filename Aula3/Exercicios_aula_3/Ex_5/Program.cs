using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0;
            float salario=0f,media,total;
            string sair="";

            while (sair!= "sim"){
                Console.WriteLine("Entre com o salário: ");
                salario=float.Parse(Console.ReadLine());
                
                total= salario*cont;
                cont++;
                
                Console.WriteLine("Deseja calcular a média[sim/não]?");
                sair= Console.ReadLine().ToLower();
            }
            media=salario/cont;

            Console.WriteLine($"Seu número de funcionários é {cont} e a média de salário entre eles é {media}");
        }
    }
}
