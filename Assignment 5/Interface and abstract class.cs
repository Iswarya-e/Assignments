using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMI
{

    interface I
    {
        void GetDetails(int a,int b,int c);
    }
    public abstract class Salary
    {
        public int basic;
        public int DA;
        public int PT;
        public abstract void CalculateSalary();
    }
    public class Implemetation : Salary,I
    {
        public   void GetDetails(int b,int da,int pt)
        {
            this.basic = b;
            this.DA = da;
            this.PT = pt;
        }
        public override void CalculateSalary()
        {
            int sal = this.basic + this.DA - this.PT;
            Console.WriteLine("Salary:" + sal);
        }


    }
    internal class Program
    {



        static void Main()
        {
            Console.WriteLine("Enter the Basic:");
            int basic=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the DA:");
            int da = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Professional Tax:");
            int pt = Convert.ToInt32(Console.ReadLine());
            Implemetation implemetation = new Implemetation();
            implemetation.GetDetails(basic,da,pt);
            implemetation.CalculateSalary();
            Console.ReadLine();
        }
    }
}
