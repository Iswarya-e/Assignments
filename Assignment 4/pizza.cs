
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bill
    {
        int pizza;
        int burg;
        int cdrink;
        int tea;
        public Bill(int p, int q, int c, int t)
        {
            this.pizza = p;
            this.burg = q;
            this.cdrink = c;
            this.tea = t;
        }
        public int CalculateBill()
        {
            int final;
            final = this.pizza * 450 + this.burg * 350 + this.cdrink * 100 + this.tea * 50;
            return final;
        }



    }
    internal class Pizza
    {
        static void Main()
        {
            Console.WriteLine("MENU A. Pizza cost =450 B.Burger cost = 350 C.Cold  Drink = 100 D.Tea cost = 50; ");
            int pizzaQ, burgerQ, coldQ, teaQ;

            Console.WriteLine("Enter the Quantity of Pizza");
            pizzaQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of Burger");
            burgerQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of Cold Drink");
            coldQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of Tea");
            teaQ = Convert.ToInt32(Console.ReadLine());

            Bill order = new Bill(pizzaQ, burgerQ, coldQ, teaQ);
            int final = order.CalculateBill();
            if (final >= 10000)
            {
                double discountedprice = final - final * 10 / 100;
                Console.WriteLine("FINAL BILL AMOUNT:" + discountedprice);
            }
            else if (final > 10000 && final <= 50000)
            {
                double discountedprice = final - final * 30 / 100;
                Console.WriteLine("FINAL BILL AMOUNT:" + discountedprice);
            }
            else
            {
                Console.WriteLine("FINAL BILL AMOUNT:" + final);
            }

            Console.ReadLine();


        }

    }
}
