namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName);

            int score;
            score = 53;
            score = 54;
            Console.WriteLine(score); // Outputs: 54

            int a = 5;
            int b = 6;

            b = a;

            Console.WriteLine(a); // Outputs: 5
            Console.WriteLine(b); // Outputs: 5
        }
    }
}