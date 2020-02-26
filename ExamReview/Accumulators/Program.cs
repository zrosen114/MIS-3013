//Zack Rosen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double multi = 1;

            for (int i = 1; i <= 100; i++)
            {
                number += i;
                multi *= i;
            }

            Console.WriteLine("Total add number equals " + number.ToString("N0"));
            Console.WriteLine("Total multi number equals " + multi.ToString("N0"));
            Console.ReadKey();
        }
    }
}
