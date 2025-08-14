using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // adding two integers
            int firstNumber = 12;
            int secondNumber = 7;
            // here + means numerical addition because both operands are integers
            Console.WriteLine(firstNumber + secondNumber);


            // mixing string and integer
            string firstName = "Bob";
            int widgetsSold = 7;
            // here + means string concatenation because firstName is a string
            // C# will automatically convert widgetsSold (int) into a string
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");


            // tricky case - mixing int addition and string concatenation without parentheses
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
            // this does NOT add 7 to widgetsSold
            // the compiler converts widgetsSold to a string first, then concatenates "7"

            // correct way - using parentheses to force the addition first
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            // here (widgetsSold + 7) is done first because of parentheses


            // + is overloaded → It works for both number addition and string concatenation.
            // Compiler decides usage based on operand types.
            // Implicit conversion → int is automatically converted to string when needed for concatenation.
            // Parentheses() can control operation order to avoid confusion.

        }
    }
}
