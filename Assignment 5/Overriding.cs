using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    abstract class overridingexample
    {
        public int fact = 1;
        public abstract int calculate(int n);
    }
    class Factorial:overridingexample
    {
        public int fact = 1;
        public override int calculate(int n)
        {
            
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    class Square: overridingexample
    {
        public override int calculate(int n)
        {
            return n*n;
        }

    }
    class Cube : overridingexample
    {
        public override int calculate(int n)
        {
            return n*n*n;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            Factorial facto=new Factorial();
            Console.WriteLine(facto.calculate(n));
            Square square=new Square();
            Console.WriteLine(square.calculate(n));
            Cube cube=new Cube();
            Console.WriteLine(cube.calculate(n));
            Console.ReadLine();
        }
    }
}
