using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveXYears
{
    class Program
    {
        static void Main(string[] args)
        {
            int weeks = 4;
            int months = 12;

            Console.WriteLine("How much money do you want to save per week?");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the interest rate per month?");
            double monthrate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many years do you want to save for?");
            int useryears = Convert.ToInt32(Console.ReadLine());

            double principalpermonth = principal * weeks;
            double principalperyear = principalpermonth * months;
            double monthpercentrate = monthrate / 100;
            double yearpercentrate = monthpercentrate * months;

            double saved = principalperyear * yearpercentrate * useryears;

            Console.WriteLine("Year " + useryears + ": " + saved);


            for (int year = 1; year <= useryears; year++)
            {

            }

            








            Console.ReadKey();
        }
    }
}
