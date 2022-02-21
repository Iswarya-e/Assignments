using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{


    public class Bank
    {
        public int no_of_years;
        public double p;
        
    }
    public class BOI:Bank
    {
        double r=10.2/100;
        public BOI(int a, double b)
        {
            this.no_of_years = a;
            this.p = b;
            double si = (this.r * this.no_of_years * this.p)/100;
            Console.WriteLine("Simple Interest:" + si);
        }
    }
    public class Axis:Bank
    {
        double r = 9 / 100;
        public Axis(int a, double b)
        {
            this.no_of_years = a;
            this.p = b;
            double si = (this.r * this.no_of_years * this.p) / 100;
            Console.WriteLine("Simple Interest:" + si);
        }

    }
    public class Cosmos:Bank
    {
        double r = 9 / 100;
        public Cosmos(int a, double b)
        {
            this.no_of_years = a;
            this.p = b;
            double si = (this.r * this.no_of_years * this.p) / 100;
            Console.WriteLine("Simple Interest:" + si);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banks:1.BOI,2:Axis,3:Cosmos");
            Console.WriteLine("Enter your choice of  Bank :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Principal:");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of years:");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1: BOI bank1 = new BOI(n,p); break;
                case 2: Axis bank2 = new Axis(n,p);break;
                case 3: Cosmos bank3 = new Cosmos(n,p);break;

            }
            Console.ReadLine();


        }
    }
}
