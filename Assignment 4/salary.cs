

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     internal class Salary
    {
        static void Main(String []args)
        {
            double DA, TA, salary, bonus, salary1;
            Console.WriteLine("Enter the Basic salary");
            int num = Convert.ToInt32(Console.ReadLine());
            DA = 0.8 * num;
            TA = 0.7 * num;
            salary = num + DA + TA;
            if (salary >= 50000 && salary <= 60000)
            {
                bonus = 0.1 * salary; ;
                salary1 = salary + bonus;
                Console.WriteLine("Original salary: " + salary + "  Your Bonus: " + bonus + "   Your Salary after hike:" + salary1);
            }
            else if (salary < 50000)
            {
                bonus = 0.8 * salary;
                salary1 = salary + bonus;
                Console.WriteLine("Original salary: " + salary + "  Your Bonus: " + bonus + "   Your Salary after hike:" + salary1);
            }
            else if (salary > 100000)
            {
                bonus = 0.5 * salary;
                salary1 = salary + bonus;
                Console.WriteLine("Original salary: " + salary + "  Your Bonus: " + bonus + "   Your Salary after hike:" + salary1);
            }


            Console.ReadLine();


        }

    }
}
