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
            double pmt = 0;
            double interest = 0;
            double FV = 0;
            int yearstosave = 0;
            int months = 1;
            int years = 1;

            Console.WriteLine("How much money will you save per week?");
            pmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your interest rate per month? If your interest is 4% please input 4.");
            interest = Convert.ToDouble(Console.ReadLine()) /100;

            Console.WriteLine("How many years would you like to save?");
            yearstosave = Convert.ToInt32(Console.ReadLine());

            for (int N = 1; N <= yearstosave * 12; N++)
            {
                FV += pmt * 4;
                FV += FV * interest;

                string monthname = months.ToString("N0");

                if (months == 1)
                {
                    monthname = "January";

                }
                else if (N == 2)
                {
                    monthname = "February";

                }
                else if (months == 3)
                {
                    monthname = "March";

                }
                else if (months == 4)
                {
                    monthname = "April";

                }
                else if (months == 5)
                {
                    monthname = "May";

                }
                else if (months == 6)
                {
                    monthname = "June";

                }
                else if (months == 7)
                {
                    monthname = "July";

                }
                else if (months == 8)
                {
                    monthname = "August";

                }
                else if (months == 9)
                {
                    monthname = "September";

                }
                else if (months == 10)
                {
                    monthname = "October";

                }
                else if (months == 11)
                {
                    monthname = "November";

                }
                else
                {
                    monthname = "December";
                }

                Console.WriteLine(monthname + " @ Year " + years.ToString("N0") + ": " + FV.ToString("C2"));

                months++;

                if (N % 12 == 0)
                {
                    years++;
                    months = 1;
                }

            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
