using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1;
            int total=0;
            int num=0;
            int resposta=1;
        
        while (cont<=3){
            Console.WriteLine("Digite um número: ");
            num=int.Parse(Console.ReadLine());

            if (num%2!=0){
                total= num+total;
            } 
            if(num%3==0){
                resposta=resposta*num;  //Porduto é ele*ele*o num
            }
            cont++;
        }
        Console.WriteLine($"{total} {resposta}");
       
        }
    }
}
