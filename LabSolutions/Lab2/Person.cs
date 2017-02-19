namespace Lab2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static double SumOfAllAges;
        public void GetUserData()
        {
            System.Console.Write("What is your first name? ");
            this.FirstName = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            this.LastName = System.Console.ReadLine();
            System.Console.Write("How old are you? ");
            this.Age = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your spouse's first name? ");
            this.Spouse.FirstName = System.Console.ReadLine();
            System.Console.Write("How old is your spouse? ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());
            this.Spouse.LastName = this.LastName;
            SumOfAllAges += this.Age + this.Spouse.Age;
        }
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " " + "(" + Age + ")");
        }
    }
}
