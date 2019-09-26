using System;

namespace aula8
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] v1={"a","b","c"};

           //Laço  FOREACH(para cada);
           foreach(string letra in v1){
               Console.WriteLine(letra);
           }
        }
    }
}
