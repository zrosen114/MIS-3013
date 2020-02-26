//Zack Rosen
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
            const int weeks = 4;
            const int months = 12;
            double pmt = 0;
            double interest = 0;
            int years = 0;
            double FV = 0;

            Console.WriteLine("How much money will you save per week?");
            pmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your interest rate per month? If your interest is 4% please input 4.");
            interest = Convert.ToDouble(Console.ReadLine()) /100;

            Console.WriteLine("How many years would you like to save?");
            years = Convert.ToInt32(Console.ReadLine());

            for (int N = 1; N <= years * months; N++)
            {
                FV += pmt * weeks;
                FV += FV * interest;
                Console.WriteLine("Month " + N.ToString("N0") + ": " + FV.ToString("C2"));
            }

            Console.ReadKey();
        }
    }
}
