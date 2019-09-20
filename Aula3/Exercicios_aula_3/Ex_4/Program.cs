using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cont, num, neg=0, res, cont1=1;
            string pos="";
            
            
            for (cont=1; cont<=20;cont++){
                Console.WriteLine("Digite um número: ");
                num=int.Parse(Console.ReadLine());
                if (num>0){
                   pos+= num.ToString() +" ";
                } else{
                    neg+=num;
                    cont1 ++;
                }
            }
            res=neg/cont;
            Console.WriteLine($"Os números positivos são {pos} e a média de números negativo é {res}");
        }
    }
}
