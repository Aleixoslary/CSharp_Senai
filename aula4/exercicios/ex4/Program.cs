using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] a = new string [15];
            string[] b = new string[15];
            string[] c = new string [30];

            for (int i=0; i<15; i++){
                Console.WriteLine("Digite uma palavra: ");
                 a[i]=Console.ReadLine();
            }
             for (int i=0; i<15; i++){
                Console.WriteLine("Digite uma palavra: ");
                 b[i]=Console.ReadLine();
            }
             for (int i=0; i<15;i++){
                c[i]=a[i];
                c[i+15]=b[i];
            }
            for (int i=0; i<30;i++){
                Console.WriteLine(c[i]);
            }
        }
    }
}
