namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketOrder YourTicketOrder = new TicketOrder();
            ConcessionOrder YourConcessionOrder = new ConcessionOrder();

            Message.PrintWelcome();
            Message.PrintPromotions();

            YourTicketOrder.GetTicketOrder();
            YourConcessionOrder.GetConcessionOrder();

            YourConcessionOrder.TicketDiscountPromotion(YourTicketOrder);
            YourTicketOrder.PopcornPromotion(YourConcessionOrder);
            YourConcessionOrder.CandyPromotion();

            Message.PrintReview();
            YourTicketOrder.PrintYourTicketOrder();
            YourConcessionOrder.PrintYourConcessionOrder();
            YourConcessionOrder.PrintGrandTotal(YourTicketOrder);

            Message.PrintThankYou();
            System.Console.ReadKey();
        }
    }
}
