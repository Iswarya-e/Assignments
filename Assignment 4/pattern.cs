
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Pattern
    {
        static void Main()
        {
            int i, j;
            int n = 5;
            int k = 1;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)(k + 64));
                    k++;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        


        int i1, j1;
        int n1 = 6;
        for (i1 = n1; i1 >=1; i1--)
        {
            for (j1 = 1; j1 <= i1; j1++)
            {
                 Console.Write((char)(j1+96));
 
             }

             Console.WriteLine("");
         }
            Console.ReadLine();


            int i2, j2;
            int n2 = 4;
            int k2 = 2;
            for (i2 = 1; i2 <= n2; i2++)
            {
                for (j2 = 1; j2 <= i2; j2++)
                {
                    Console.Write(k2+" ");
                    k2+=2;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            int i3, j3;
            int n3 = 6;
            for (i3 = n3; i3 >= 1; i3--)
            {
                for (j3 = 1; j3 <= i3; j3++)
                {
                    Console.Write("*");

                }

                Console.WriteLine("");
            }
            Console.ReadLine();


            int i4, j4;
            int n4 = 5;

            for (i4 = 1; i4 <= n; i4++)
            {

                for (j4 = 1; j4 <= n4 - i4; j4++)
                {
                    Console.Write(" ");
                }
                for (j4 = 1; j4 <= i4; j4++)
                {
                    Console.Write((char)(j4 + 64));
                }
                for (j4 = i4 - 1; j4 >= 1; j4--)
                {
                    Console.Write((char)(j4 + 64));
                }

                Console.WriteLine();
            }


            
            Console.ReadLine();
        }


    }

}
