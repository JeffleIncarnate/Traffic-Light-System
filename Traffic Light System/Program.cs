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

            if (BiggestNum(50, 23, 66, 12) == 1)
            {
                Console.WriteLine("Failed");
                Console.WriteLine();
            } else
            {
                Console.WriteLine("The biggest number is " + BiggestNum(50, 23, 66, 12));
                Console.WriteLine("Success\n");
            }

            if (SmallestNum(50, 23, 66, 12) == 1)
            {
                Console.WriteLine("Failed");
                Console.WriteLine();
            } else
            {
                Console.WriteLine("The smallest number is " + SmallestNum(50, 23, 66, 12));
                Console.WriteLine("Sucess\n");
            }

            EqualNum(50, 23, 66, 12);

            IntArrayBubbleSort(theArray, 50, 23, 66, 12);

            forEachNumer(theArray2, 50, 23, 66, 12);

            Console.ReadLine();
        }

        // This method is a void that calculates the Bigges num, then returns it back to the main Method
        public static int BiggestNum(int a, int b, int c, int d)
        {
            int biggestNum = 0;
            bool isPassed = false;

            /* 
                This while loop runs through the code over and over again to check if one intager is bigger
                the other ones e.g a > b or c < a
            */
            // BIGGER CONDITIONAL STATEMENTS 
            if (a > b && a > c && a > d)
            {
                biggestNum = a;
                isPassed = true;
            }
            else if (b > a &&  b > c && b > d)
            {
                biggestNum = b;
                isPassed = true;
            }
            else if (c > a && c > b && c > d)
            {
                biggestNum = c;
                isPassed = true;
            }
            else if (d > a && d > b && d > c)
            {
                biggestNum = d;
                isPassed = true;
            }

            if (isPassed == true)
            {
                return biggestNum;
            } else
            {
                return 1;
            }
        }

        /*
            This method gets the smallest intager between the 4 intagers that it takes as a parameter then it 
            returns it back to the Main Method
        */
        public static int SmallestNum(int a, int b, int c, int d)
        {
            int smallestNum = 0;
            bool isPassed = false;

            // BIGGER CONDITIONAL STATEMENTS 
            if (a < b && a < c && a < d)
            {
                smallestNum = a;
                isPassed = true;
            }
            else if (b < a && b < c && b < d)
            {
                smallestNum = b;
                isPassed = true;
            }
            else if (c < a && c < b && c < d)
            {
                smallestNum = c;
                isPassed = true;
            }
            else if (d < a && d < b && d < c)
            {
                smallestNum = d;
                isPassed = true;
            }

            if (isPassed == true)
            {
                return smallestNum;
            } else
            {
                return 1;
            }
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
            // This
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        /* 
            This Method sorts the Array based on how larget of small the last number is so when the loop is 
            finished, it'll return the array back to the Main funtion
        */
        // Bubble sort algorithem
        public static void IntArrayBubbleSort(int[] arr, int a, int b, int c, int d)
        {
            int temp;

            // This loop gets the length of the array -- it also check to see if the first num is less or more
            // It checks to see if the first int is bigger, and it changes it if it's bigger
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                // This Loop does the exact same thing as the outer loop
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    // This is a if statement that exchanges the 2 varaibles for for the temp variable
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            // This writes the sorted list to the Console using a foreach loop 
            Console.Write("Sorted: ");
            foreach (int p in arr)
                Console.Write(p + ", ");
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
