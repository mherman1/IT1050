namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            bool isCitizen;
            bool canVote;

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + "." + " " + lastName;

            System.Console.Write("What is your base height in feet? Choose 4, 5, or 6. ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet are you? Convert fractions to a decimal. ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;
            
            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? Choose true or false. ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            
            canVote = age >= 18 && isCitizen;
            
            System.Console.WriteLine("Your name is " + fullName + ".");
            System.Console.WriteLine("Your are " + totalHeightCM + " " + "cm tall.");

            if(canVote == true)
            {
                System.Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                System.Console.WriteLine("You are not eligible to vote.");
            }

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
