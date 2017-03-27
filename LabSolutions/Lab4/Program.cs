namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketOrder YourTicketOrder  = new TicketOrder();
            ConcessionOrder YourConcessionOrder = new ConcessionOrder();

            System.Console.WriteLine("Welcome to the MovieTicketCalculator!");
            System.Console.WriteLine("\nOur discounts and promotions:");
            System.Console.WriteLine("*Buy a popcorn plus a large soda and get $2 off one ticket!");
            System.Console.WriteLine("*Buy 3 or more tickets and get one bag of popcorn free!");
            System.Console.WriteLine("*Buy 3 candies and get the 4th free!");
            System.Console.Write("\nWould you like to attend a matinee or evening showing? ");
            string Time = System.Console.ReadLine();

            YourTicketOrder.GetTicketOrder();

            if (Time.ToLower().Contains("matinee"))
            {
                YourTicketOrder.GetMatineeTicketCost();
            }
            else
            {
                YourTicketOrder.GetEveningTicketCost();
            }

            System.Console.Write("\nWould you like to purchase concessions? ");
            string ConcessionInput = System.Console.ReadLine();

            if (ConcessionInput.ToLower().StartsWith("y"))
            {
                YourConcessionOrder.GetConcessionOrder();
                YourConcessionOrder.GetConcessionCost();
            }

            YourTicketOrder.PopcornPromotion(YourConcessionOrder);
            YourConcessionOrder.TicketPromotion(YourTicketOrder);

            YourTicketOrder.YourTickets();
            YourConcessionOrder.YourConcessions();

            YourConcessionOrder.GetandPrintGrandTotal(YourTicketOrder);

            System.Console.WriteLine("\nThank you for using the MovieTicketCalculator! ");
            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}
