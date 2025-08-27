namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

/*

Anything inside "" is called a string literal.
We could also make other types of literals, like number literals.

Console and WriteLine are called identifiers.
A namespace is a way to group related code together.

The dot (.) is called the member access operator. WriteLine is a member of the Console class.

Namespace -> Class -> Method -> Statement -> Expression -> Literal/Identifier

Base Class Library (BCL) // The Base Class Library contains many namespaces, each with many classes, each with many members that come with .NET.
    - System
        - Console
            - WriteLine()

Console.WriteLine("Hello, World!"); -> This is a statement.

*/