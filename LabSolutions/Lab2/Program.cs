namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.GetUserData();
            p2.GetUserData();

            System.Console.WriteLine(Person.SumOfAllAges/2);            
            System.Console.ReadKey();
        }
    }
}
