using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] v1 = new double [10];
            double[] v2 = new double [10];
            double[] v3 = new double [20];

            for (int i=0; i<=9;i++){
                Console.Write("Digite um número: ");
                v1[i]=double.Parse(Console.ReadLine());
            }
            
            for (int i=0; i<=9;i++){
                Console.Write("Digite um número: ");
                v2[i]=double.Parse(Console.ReadLine());
            }

            for (int i=0; i<=9;i++){
                v3[i]=v1[i];
                v3[i+10]=v2[i];
            }
            for (int i=0; i<=19;i++){
                Console.WriteLine(v3[i]);
            }
        }
    }
}
