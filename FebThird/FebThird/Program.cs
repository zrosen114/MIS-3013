using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebThird
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count to? >>");
            //string input = Console.ReadLine();
            // int threshold = Convert.ToInt32(input);
            int threshold = Convert.ToInt32(Console.ReadLine());
            //could also use i < 101
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }

            double sum = 0;
            string answer;

            do
            {
                Console.WriteLine("Please give us a # to add >>");
                int number = Convert.ToInt32(Console.ReadLine());
                //sum = sum + number;
                sum += number;

                Console.WriteLine("Do you have another # to add? (y,n) >>");
                answer = Console.ReadLine();

            } while (answer == "y");
            //}while (answer != "n");
            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}");






            Console.ReadKey();
        }
    }
}
