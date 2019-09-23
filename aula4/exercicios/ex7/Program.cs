using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int [10];
            int maior=0;
            int ind=0;


            for (int i=0; i<=9; i++){
                Console.Write($"Digite o {i+1}º número: ");
                v1[i]=int.Parse(Console.ReadLine());

                if (i==0){
                    maior=v1[i];
                }

                if (maior<v1[i]){
                    ind=i+1;
                    maior=v1[i];
                   }
            }   
             Console.Write($"{ind} : {maior}");
           
        }
    }
}
