﻿using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] v1= new int [10];
        

         for (int i=0; i<9; i++){

             v1[i]= i*2;

            }

            for (int i=0; i<=9; i++){
             Console.WriteLine(v1[i]);
            }
       
        }
    }
}
