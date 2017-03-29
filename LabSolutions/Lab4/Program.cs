namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketOrder YourTicketOrder = new TicketOrder();
            ConcessionOrder YourConcessionOrder = new ConcessionOrder();

            System.Console.WriteLine("Welcome to the MovieTicketCalculator!");
            System.Console.WriteLine("\nOur discounts and promotions:");
            System.Console.WriteLine("*Buy a popcorn plus a large soda and get $2 off one ticket!");
            System.Console.WriteLine("*Buy 3 or more tickets to an evening show and get one bag of popcorn free!");
            System.Console.WriteLine("*Buy 3 candies and get the 4th free!");

            System.Console.Write("\nWould you like to attend a matinee or evening showing? ");
            string Time = System.Console.ReadLine();
            YourTicketOrder.GetTicketOrder(Time);

            System.Console.Write("\nWould you like to purchase concessions? ");
            string ConcessionInput = System.Console.ReadLine();
            YourConcessionOrder.GetConcessionOrder(ConcessionInput);

            YourConcessionOrder.TicketDiscountPromotion(YourTicketOrder);
            YourTicketOrder.PopcornPromotion(YourConcessionOrder, Time);
            YourConcessionOrder.CandyPromotion();

            System.Console.Write("\nReview your order... ");
            YourTicketOrder.PrintYourTicketOrder();
            YourConcessionOrder.PrintYourConcessionOrder();
            YourConcessionOrder.GetGrandTotal(YourTicketOrder);

            System.Console.WriteLine("\nThank you for using the MovieTicketCalculator! ");
            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}
