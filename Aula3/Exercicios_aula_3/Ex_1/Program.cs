using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0;

            for (double cont=1; cont<=100;cont++){

                //FUNÇÃO DA POTENCIAÇÃO Math.Pow(base,potencia);
                num= Math.Pow(cont,3);

                Console.WriteLine($"{cont} elavado a três é {num}");
            }
            
        }
    }
}
