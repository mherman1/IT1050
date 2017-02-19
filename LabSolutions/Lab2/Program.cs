namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Spouse = new Person();
            p2.Spouse = new Person();
            p1.Spouse.Spouse = p1;
            p2.Spouse.Spouse = p2;

            System.Console.WriteLine("User 1");
            p1.GetUserData();
            System.Console.WriteLine("\nUser 2");
            p2.GetUserData();

            System.Console.WriteLine("\nYour names and ages:");
            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            System.Console.WriteLine("Your average age is " + Person.SumOfAllAges/4 + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
