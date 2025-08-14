using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Basic string interpolation ---
            string firstName = "Bob";
            string message = $"Hello {firstName}!";
            Console.WriteLine(message);

            // --- String interpolation with multiple variables ---
            int version = 11;
            string updateText = "Update to Windows";
            string message2 = $"{updateText} {version}";
            Console.WriteLine(message2);

            // --- Avoid intermediate variables ---
            int version2 = 11;
            string updateText2 = "Update to Windows";
            Console.WriteLine($"{updateText2} {version2}!");

            // --- Combine verbatim literals with string interpolation ---
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");


        }
    }
}
