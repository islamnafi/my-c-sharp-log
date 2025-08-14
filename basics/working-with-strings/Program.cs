using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Basic escape sequences: \n (newline) and \t (tab)
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");

            // Escaping double quotes
            Console.WriteLine("Hello \"World\"!");

            // Backslashes in file paths
            Console.WriteLine("Escaped   : c:\\source\\repos");   // using \\
            Console.WriteLine(@"Verbatim  : c:\source\repos");    // using @

            // Verbatim string preserving whitespace
            Console.WriteLine(
    @"    c:\source\repos    
        (this is where your code goes)");

            // Mock CLI (English)
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // Mock CLI (Japanese with Unicode)
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            // Concatenate a literal string and a variable
            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);
            // Output: Hello Bob

            // Concatenate multiple variables and literal strings
            string greeting = "Hello";
            message = greeting + " " + firstName + "!";
            Console.WriteLine(message);
            // Output: Hello Bob!

            // Avoiding extra variables
            Console.WriteLine(greeting + " " + firstName + "!");
            // Output: Hello Bob!

        }
    }
}
