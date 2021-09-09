using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a option you want: \n 1-Fibonacci \n 2-PerfectNumber \n 3-Prime Number \n 4-Reverse a number \n 5-Coupon number \n 6-Elapsed time od stopwatch");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci.FibonacciSeries();
                    Console.ReadLine();
                    break;
                case 2:
                    Perfect.PerfectNumber();
                    Console.ReadLine();
                    break;
                case 3:
                    Prime.PrimeNumber();
                    Console.ReadLine();
                    break;
                case 4:
                    Reverse.ReverseNumber();
                    Console.ReadLine();
                    break;
                case 5:
                    CouponNumber.GenerateCoupon();
                    Console.ReadLine();
                    break;
                case 6:
                    Stopwatchtime.Elapsed();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
