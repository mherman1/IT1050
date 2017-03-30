namespace Lab4
{
    class Message
    {
        public static void PrintWelcome()
        {
            System.Console.WriteLine("Welcome to the MovieTicketCalculator!");
        }

        public static void PrintPromotions()
        {
            System.Console.WriteLine("\nOur discounts and promotions:");
            System.Console.WriteLine("*Buy a popcorn plus a large soda and get $2 off one ticket!");
            System.Console.WriteLine("*Buy 3 or more tickets to an evening show and get one bag of popcorn free!");
            System.Console.WriteLine("*Buy 3 candies and get the 4th free!");
        }

        public static void PrintReview()
        {
            System.Console.Write("\nReview your order... ");
        }

        public static void PrintThankYou()
        {
            System.Console.WriteLine("\nThank you for using the MovieTicketCalculator! ");
            System.Console.Write("Press any key to continue... ");
        }
    }
}
