using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    internal class Program
    {
        // This is the Main Method, every time I start the compiler, this method starts fist
        static void Main(string[] args)
        {
            // Varaiables
            int[] theArray = { 50, 23, 66, 12 };
            int[] theArray2 = { 50, 23, 66, 12 };

            BiggestNum(50, 23, 66, 12);
            Console.WriteLine("Passed");

            SmallestNum(50, 23, 66, 12);
            Console.WriteLine("Passed");

            EqualNum(50, 23, 66, 12);
            Console.WriteLine("Passed");

            IntArrayBubbleSort(theArray, 50, 23, 66, 12);
            Console.WriteLine("\nPassed");

            forEachNumer(theArray2, 50, 23, 66, 12);
            Console.WriteLine("\nPassed");

            stackNumbers();

            Console.ReadLine();
        }

        // This method is a void that calculates the Bigges num, then returns it back to the main Method
        public static void BiggestNum(int a, int b, int c, int d)
        {
            int biggestNum;

            /* 
                This while loop runs through the code over and over again to check if one intager is bigger
                the other ones e.g a > b or c < a
            */
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

        /*
            This method gets the smallest intager between the 4 intagers that it takes as a parameter then it 
            returns it back to the Main Method
        */
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

        /*
            This Method Looks for what 2 intagers have the same value, then it returns the value back the the 
            main Method
        */
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

        /*
            This method takes in 3 elements, an array, and 2 intagers, it then exchanges the values till
            the value of temporary is the same
        */
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        /* 
            This Method sorts the Array based on how larget of small the last number is so when the loop is 
            finished, it'll return the array back to the Main funtion
        */
        public static void IntArrayBubbleSort(int[] arr, int a, int b, int c, int d)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.Write("Sorted: ");
            foreach (int p in arr)
                Console.Write(p + " ");
        }

        /* 
            This method takes in an intager array then the foreach funtion takes those 4 ints and prints
            them out
        */
        public static void forEachNumer(int[] numbers, int a, int b, int c, int d)
        {
            foreach(int number in numbers)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
