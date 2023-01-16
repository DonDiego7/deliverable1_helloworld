namespace Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string stg = "Hello, World! (2)";
            Console.WriteLine(stg);
            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Enter user's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User's age is: " + age);
        }
    }
}