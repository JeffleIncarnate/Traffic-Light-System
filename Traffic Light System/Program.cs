using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BiggestNum(1, 10, 30, 50);
            Console.WriteLine("Passed");

            SmallestNum(10, 40, 50, 100);
            Console.WriteLine("Passed");

            Console.ReadLine();
        }

        public static void BiggestNum(int a, int b, int c, int d)
        {
            int biggestNum;

            while (true)
            {
                // BIGGER CONDITIONAL STATEMENTS 
                if (a > b && a > c && a > d)
                {
                    biggestNum = a;
                    break;
                }
                else if (b > a &&  b > c && b > d)
                {
                    biggestNum = b;
                    break;
                }
                else if (c > a && c > b && c > d)
                {
                    biggestNum = c;
                    break;
                }
                else if (d > a && d > b && d > c)
                {
                    biggestNum = d;
                    break;
                }
            }

            Console.WriteLine("The Biggest Number is " + biggestNum);
        }

        public static void SmallestNum(int a, int b, int c, int d)
        {
            int smallestNum;

            while (true)
            {
                // BIGGER CONDITIONAL STATEMENTS 
                if (a < b && a < c && a < d)
                {
                    smallestNum = a;
                    break;
                }
                else if (b < a && b < c && b < d)
                {
                    smallestNum = b;
                    break;
                }
                else if (c < a && c < b && c < d)
                {
                    smallestNum = c;
                    break;
                }
                else if (d < a && d < b && d < c)
                {
                    smallestNum = d;
                    break;
                }
            }

            Console.WriteLine("The Smallest Number is " + smallestNum);
        }
    }
}
