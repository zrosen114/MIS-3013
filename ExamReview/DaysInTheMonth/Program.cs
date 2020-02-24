using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int jan = 31;
            int feb = 28;
            int mar = 31;
            int apr = 30;
            int may = 31;
            int jun = 30;
            int jul = 31;
            int aug = 31;
            int sep = 30;
            int oct = 31;
            int nov = 30;
            int dec = 31;
            int days = 0;



            Console.WriteLine("Please type the name of a month.");
            string userinput = Console.ReadLine().ToLower();



            if (userinput == "january")
            {
                days = jan;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }

            else if (userinput == "february")
            {
                Console.WriteLine("Is it a leap year? (y/n)");
                string leap = Console.ReadLine().ToLower();
                if (leap == "y")
                {
                    days = feb + 1;
                }
                else
                {
                    days = feb;
                }

                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "march")
            {

                days = mar;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "april")
            {

                days = apr;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "may")
            {

                days = may;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "june")
            {

                days = jun;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "july")
            {

                days = jul;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "august")
            {

                days = aug;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "september")
            {

                days = sep;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "october")
            {

                days = oct;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "november")
            {

                days = nov;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else if (userinput == "december")
            {

                days = dec;
                Console.WriteLine("There are " + days + " days in the month of " + userinput);
            }
            else
            {
                Console.WriteLine("There was an error with your answer. Please try again.");
                
            }

            Console.ReadKey();
        }
    }
}
