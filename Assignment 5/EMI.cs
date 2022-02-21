using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMIcalulator
{
    public class Emi
    {
        public double principal;
        public double no_of_years;
        public double Principal
        {
            get { return principal; }
            set { principal = value; }
        }
        public double Years 
        {
            get { return no_of_years; }
            set { no_of_years = value; }
        }
    }
    public class Axis:Emi
    {
        double emi_per_year;
        double emi_per_month;
        double rate = 0.18;
        
        public void Calculate()
        {
            rate /= 12;
            no_of_years *= 12;
            this.emi_per_month = principal * rate * Math.Pow(1 + rate, no_of_years) / (Math.Pow(1 + rate, no_of_years) - 1);
            this.emi_per_year = 12 * emi_per_month;
        }
        public double MONTHLY_EMI
            {
                get { return emi_per_month; }
            }
            public double YEARLY_EMI 
            {
                get { return emi_per_year; }
            }
    }
    public class BOI : Emi
    {
        double emi_per_year;
        double emi_per_month;
        double rate = 0.28;

        public void Calculate()
        {
            rate /= 12;
            no_of_years *= 12;
            emi_per_month = principal*rate*Math.Pow(1+rate,no_of_years)/ (Math.Pow(1 + rate, no_of_years) - 1);
            emi_per_year = 12 * emi_per_month;
        }
        public double MONTHLY_EMI
        {
            get { return emi_per_month; }
        }
        public double YEARLY_EMI
        {
            get { return emi_per_year; }
        }
    }
    public class Cosmos : Emi
    {
        double emi_per_year;
        double emi_per_month;
        double rate = 0.28;

        public void Calculate()
        {
            rate /= 12;
            no_of_years *= 12;
            emi_per_month = principal * rate * Math.Pow(1 + rate, no_of_years) / (Math.Pow(1 + rate, no_of_years) - 1);
            emi_per_year = 12 * emi_per_month;
        }
        public double MONTHLY_EMI
        {
            get { return emi_per_month; }
        }
        public double YEARLY_EMI
        {
            get { return emi_per_year; }
        }
    }

    internal class Program
    {
        static void Main()
        {
        Console.WriteLine("Choose Bank 1.Axis 2.BOI 3.Cosmos");
        int ch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENter the Principal");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the time in years");
        double years = Convert.ToDouble(Console.ReadLine());
        switch(ch)
        {
            case 1: Axis Axisemi = new Axis();
                    Axisemi.Principal = p;
                    Console.WriteLine(Axisemi.Principal);
                    Axisemi.Years = years;
                    Axisemi.Calculate();
                    Console.WriteLine("Emi per month:"+Axisemi.MONTHLY_EMI);
                    Console.WriteLine("Emi per Year:" + Axisemi.YEARLY_EMI);
                    break;
            case 2: BOI BOIemi = new BOI();
                    BOIemi.Principal = p;
                    BOIemi.Years = years;
                    BOIemi.Calculate();
                    Console.WriteLine("Emi per month:" + BOIemi.MONTHLY_EMI);
                    Console.WriteLine("Emi per Year:" + BOIemi.YEARLY_EMI);
                    break;
            case 3: Cosmos Cosmosemi = new Cosmos();
                    Cosmosemi.Principal = p;
                    Cosmosemi.Years = years;
                    Cosmosemi.Calculate();
                    Console.WriteLine("Emi per month:" + Cosmosemi.MONTHLY_EMI);
                    Console.WriteLine("Emi per Year:" + Cosmosemi.YEARLY_EMI);
                    break;
            }
            Console.ReadLine();


    }
    }
}
