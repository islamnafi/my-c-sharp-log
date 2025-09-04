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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); //Console.Clear() wipes the screen and fills the entire buffer with the current background color, then moves the cursor to the top-left.

            Console.WriteLine("Hello World!");

        }
    }
}
