using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int ch = 0;
            int bal = 0;
            while (ch != 4)
            {
                Console.WriteLine("MENU 1.DEPOSIT 2.WITHDRAW 3.CHECK BALANCE 4.EXIT");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter The AMOUNT to Deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        bal += deposit;
                        Console.WriteLine("Available Balance:" + bal);
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to Withdraw");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > bal)
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        else
                        {
                            bal -= withdraw;
                            Console.WriteLine("Available Balance" + bal);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Available Balance" + bal);
                        break;


                }
            }
        }
    }
}
