using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converting_strings_to_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textAge = "26";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine("Your age is: " + age);


            string textPrice = "12.99";
            decimal price = Convert.ToDecimal(textPrice);
            Console.WriteLine("The price is: " + price);

            string textNumber = "12345789";
            long number = Convert.ToInt64(textNumber);
            Console.WriteLine("The number is: " + number);

            string textFloat = "-3.14";
            float floatNumber = Convert.ToSingle(textFloat);
            Console.WriteLine("The float number is: " + floatNumber);

            string textDouble = "3.14159";
            double doubleNumber = Convert.ToDouble(textDouble);
            Console.WriteLine("The double number is: " + doubleNumber);

        }
    }
}
