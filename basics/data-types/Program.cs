using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;

            x = 100;

            int m = 0, n = -5, o = -10;

            int a = 10,
                b = 20,
                c = 30;

            long l1 = 10000000000; // but this might still not be a long
            long l2 = -10000000000L; // this is a long and we used long literal

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double d1 = 3.14D; // double literal

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float f1 = 3.14; // but this might still not be a float
            float f2 = 3.14F; // this is a float and we used float literal

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 12.99M; // decimal literal
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            char c1 = 'A'; //single character
            string s1 = "Hello, World!";

        }
    }
}
