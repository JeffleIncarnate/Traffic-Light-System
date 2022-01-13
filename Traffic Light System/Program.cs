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
            // Has to be one Higher than your current end point
            int end = 11;

            int a = 1;
            int b = 1;
            int c = 1;
            int d = 1;

            while(true)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);

                a++;
                b++;
                c++;
                d++;

                if (d >= end)
                {
                    break;
                }
            }

            Console.WriteLine("end!");
            Console.ReadLine();
        }
    }
}
