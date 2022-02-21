using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingnew
{
    public class Sample
    {
        
        public  void calculate(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial:"+fact);
        }
        public void calculate(double n)
        {
            Console.WriteLine("Square:" + n*n);
        }
        public void calculate(String na)
        {
            int n=Convert.ToInt32(na);
            Console.WriteLine("Cube:" + n * n * n);
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calcuate factorial:");
            int n = Convert.ToInt32(Console.ReadLine());
            Sample find = new Sample();
            double square = Convert.ToDouble(n);
            String cube= Convert.ToString(n);

            find.calculate(n);
            find.calculate(square);
            find.calculate(cube);
            Console.ReadLine();


        }
    }
}
