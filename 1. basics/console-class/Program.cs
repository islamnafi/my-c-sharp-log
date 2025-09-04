using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); //Console.Clear() wipes the screen and fills the entire buffer with the current background color, then moves the cursor to the top-left.

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}"); //This is string interpolation.
            Console.WriteLine("Hello, " + name); //This is string concatenation.

        }
    }
}
