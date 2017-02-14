namespace Lab2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        //public Person Spouse; Not sure how to create the Spouse variable?...

        public void GetUserData()
        {
            this.FirstName = Question.AskForString("What is your first name? ");
            this.LastName = Question.AskForString("What is your last name? ");
            this.Age = Question.AskForInteger("How old are you? ");
            SumOfAllAges += Age;
            //this.Spouse.FirstName = Question.AskForString("What is your spouse's first name? ");
            //this.Spouse.Age = Question.AskForInteger("How old is your spouse? ");
            //SumOfAllAges += Age;
        }

        public static double SumOfAllAges = 0;

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
