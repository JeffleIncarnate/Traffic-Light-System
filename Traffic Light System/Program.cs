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
            BiggestNum(1, 40, 50, 100);
            Console.WriteLine("Passed");

            SmallestNum(10, 40, 50, 100);
            Console.WriteLine("Passed");

            EqualNum(10, 40, 50, 100);
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

        public static void EqualNum(int a, int b, int c, int d)
        {
            bool equalNum = false;

            while (true)
            {
                // CHECKING IF A == AND OTHER INT
                if (a == b) {
                    Console.WriteLine("a and b are equal");
                    equalNum = true;
                    break;
                }
                else if (a == c) {
                    Console.WriteLine("a and c are equal");
                    equalNum = true;
                    break;
                }
                else if (a == d) {
                    Console.WriteLine("a and d are equal");
                    equalNum = true;
                    break;
                }


                // CHECKING IF B == AND OTHER INT
                if (b == a) {
                    Console.WriteLine("b and a are equal");
                    equalNum = true;
                    break;
                }
                else if (b == c) {
                    Console.WriteLine("b and c are equal");
                    equalNum = true;
                    break;
                }
                else if (b == d) {
                    Console.WriteLine("b and d are equal");
                    equalNum = true;
                    break;
                }


                // CHECKING IF C == AND OTHER INT
                if (c == a) {
                    Console.WriteLine("c and a are equal");
                    equalNum = true;
                    break;
                }
                else if (c == b) {
                    Console.WriteLine("c and b are equal");
                    equalNum = true;
                    break;
                }
                else if (c == d) {
                    Console.WriteLine("c and d are equal");
                    equalNum = true;
                    break;
                }


                // CHECKING IF D == AND OTHER INT
                if (d == a) {
                    Console.WriteLine("b and a are equal");
                    equalNum = true;
                    break;
                }
                else if (d == b) {
                    Console.WriteLine("d and b are equal");
                    equalNum = true;
                    break;
                }
                else if (d == c) {
                    Console.WriteLine("d and c are equal");
                    equalNum = true;
                    break;
                }

                if (equalNum == false)
                {
                    Console.WriteLine("There are no pairs in this Array");
                    break;
                }
            }
        }
    }
}
