using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_decrement_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Incrementing and Decrementing with different operators ---

            int value = 1; // start with 1

            // Increment by adding manually
            value = value + 1; // add 1 to value → now 2
            Console.WriteLine("First increment: " + value);

            // Increment using compound assignment (+=)
            value += 1; // add 1 more → now 3
            Console.WriteLine("Second increment: " + value);

            // Increment using the ++ operator
            value++; // add 1 → now 4
            Console.WriteLine("Third increment: " + value);

            // Decrement by subtracting manually
            value = value - 1; // subtract 1 → now 3
            Console.WriteLine("First decrement: " + value);

            // Decrement using compound assignment (-=)
            value -= 1; // subtract 1 → now 2
            Console.WriteLine("Second decrement: " + value);

            // Decrement using the -- operator
            value--; // subtract 1 → now 1
            Console.WriteLine("Third decrement: " + value);


            // --- Pre-increment (++value) vs Post-increment (value++) ---

            value = 1; // reset to 1

            value++; // increase first → value = 2
            Console.WriteLine("First: " + value); // prints 2

            // Post-increment: use value first, THEN increment
            Console.WriteLine($"Second: {value++}"); // prints 2, but value becomes 3 after this line

            Console.WriteLine("Third: " + value); // confirms value is now 3

            // Pre-increment: increment first, THEN use the new value
            Console.WriteLine("Fourth: " + (++value)); // increments to 4, then prints 4

        }
    }
}
