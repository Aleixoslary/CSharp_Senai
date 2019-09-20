using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // int cont=0;
            // for (cont=0; cont<20; cont++){

            // int n1=0, n2=1;

            //  for( int ac=0; ac<cont; ac++){
            
            //     int n3=n1;
            //     n1=n2;
            //     n2=n2+n3;
            //  }

            // Console.WriteLine(n1);

            int n1=0, n2=1, n3, cont=0;
            
            if (n1==0) {
                Console.WriteLine($"{n1}");

            }

            for (cont=1; cont<20;cont++){
                n3=n1;
                n1=n2;
                n2=n2+n3;

                Console.WriteLine($"{n1}");
            }
        }
    }
}
