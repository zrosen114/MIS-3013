using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation_P_
{
    class Program
    {
        static void Main(string[] args)
        {

            String s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(s1);

            Console.WriteLine("What word would you like to change from the above sentence?");
            string s2 = Console.ReadLine();

            Console.WriteLine("What would you like to change this word to?");
            string s3 = Console.ReadLine();

            bool b = s1.Contains(s2);

            if (b is false)
            {
                Console.WriteLine($"Sorry, I could not find your word ' {s2}");

                for (int i = s2.Length - 1; i >= 0; i--)
                {
                    Console.Write(s2[i]);
                }
            }

            else
            {
                string change = s1.Replace(s2, s3);
                Console.WriteLine(change);
            }

            Console.ReadKey();
        }
    }
}
