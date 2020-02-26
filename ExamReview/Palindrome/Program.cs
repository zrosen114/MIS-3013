//Zack Rosen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a random word or phrase.");
            string userinput = Console.ReadLine().ToLower();
            string userinputreversed = "";
            int index = userinput.Length - 1;

            while (index >= 0)
            {
                userinputreversed += userinput[index];
                index--;
            }

            if (userinput == userinputreversed)
            {
                Console.WriteLine(userinput + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(userinput + " is " + userinputreversed + " and is NOT a palindrome.");
            }

            Console.ReadKey();
        }
    }
}
