using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Basic Math Operations with integers ---
            int sum = 7 + 5;              // addition
            int difference = 7 - 5;       // subtraction
            int product = 7 * 5;          // multiplication
            int quotient = 7 / 5;         // integer division (truncates decimals)

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient (int division): " + quotient); // result = 1, because int can't store decimal part


            // --- Division with decimal data type to keep fractional part ---
            decimal decimalQuotient1 = 7.0m / 5;   // first number as decimal
            decimal decimalQuotient2 = 7 / 5.0m;   // second number as decimal
            decimal decimalQuotient3 = 7.0m / 5.0m; // both numbers as decimal

            Console.WriteLine($"Decimal quotient #1: {decimalQuotient1}");
            Console.WriteLine($"Decimal quotient #2: {decimalQuotient2}");
            Console.WriteLine($"Decimal quotient #3: {decimalQuotient3}");


            // --- Casting int to decimal for division when using variables ---
            int first = 7;
            int second = 5;
            decimal quotientWithCast = (decimal)first / (decimal)second; // cast both ints to decimal
            Console.WriteLine($"Quotient with casting: {quotientWithCast}");


            // --- Modulus operator (%) to find remainder ---
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // remainder = 0 → divisible
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");     // remainder = 2 → not divisible


            // --- Order of Operations (PEMDAS without exponents) ---
            int value1 = 3 + 4 * 5;     // multiplication happens first → 3 + (4*5) = 23
            int value2 = (3 + 4) * 5;   // parentheses first → (3+4) * 5 = 35

            Console.WriteLine($"Value1 (no parentheses): {value1}");
            Console.WriteLine($"Value2 (with parentheses): {value2}");


            // --- Extra: using System.Math.Pow for exponents ---
            double exponentResult = Math.Pow(2, 3); // 2 raised to the power of 3 = 8
            Console.WriteLine($"2^3 using Math.Pow: {exponentResult}");

        }
    }
}
