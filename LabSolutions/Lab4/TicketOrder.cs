namespace Lab4
{
    class TicketOrder
    {
        int ChildTickets;
        int AdultTickets;
        int SeniorTickets;
        int NumberOfTickets = 0;
        const decimal MatineeChildPrice = 3.99M;
        const decimal MatineeAdultPrice = 5.99M;
        const decimal MatineeSeniorPrice = 4.50M;
        const decimal EveningChildPrice = 6.99M;
        const decimal EveningAdultPrice = 10.99M;
        const decimal EveningSeniorPrice = 8.50M;
        decimal TicketCost = 0.00M;
        decimal DiscountTotal = 0.00M;
        decimal GrandTotal = 0.00M;

        public void GetTicketOrder(string time)
        {
            System.Console.Write("How many Child tickets? ");
            ChildTickets = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Adult tickets? ");
            AdultTickets = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Senior tickets? ");
            SeniorTickets = int.Parse(System.Console.ReadLine());

            NumberOfTickets += ChildTickets + AdultTickets + SeniorTickets;

            if (time.ToLower().Contains("matinee"))
            {
                TicketCost += (ChildTickets * MatineeChildPrice);
                TicketCost += (AdultTickets * MatineeAdultPrice);
                TicketCost += (SeniorTickets * MatineeSeniorPrice);
            }
            else
            {
                TicketCost += (ChildTickets * EveningChildPrice);
                TicketCost += (AdultTickets * EveningAdultPrice);
                TicketCost += (SeniorTickets * EveningSeniorPrice);
            }
        }

        public void PopcornPromotion(ConcessionOrder concessionOrder, string time)
        {
            if (NumberOfTickets >= 3 && time.ToLower().Contains("evening"))
            {
                concessionOrder.AddPopcorn();
            }
        }

        public void GetTicketDiscount(int popcorn, int largeSoda)
        {
            if (popcorn >= largeSoda && NumberOfTickets >= largeSoda)
            {
                DiscountTotal = largeSoda * 2;
                TicketCost -= DiscountTotal;
            }
            else if (largeSoda >= popcorn && NumberOfTickets >= popcorn)
            {
                DiscountTotal = popcorn * 2;
                TicketCost -= DiscountTotal;
            }
            else
            {
                DiscountTotal = NumberOfTickets * 2;
                TicketCost -= DiscountTotal;
            }
        }

        public void PrintYourTicketOrder()
        {
            System.Console.WriteLine("\nTickets: ");
            System.Console.WriteLine("Child = " + ChildTickets);
            System.Console.WriteLine("Adult = " + AdultTickets);
            System.Console.WriteLine("Senior = " + SeniorTickets);
            System.Console.WriteLine("Total = " + NumberOfTickets);
        }

        public void PrintGrandTotal(decimal concessionCost)
        {
            this.GrandTotal = this.TicketCost + concessionCost;
            System.Console.WriteLine("\nYour Grand Total: " + GrandTotal.ToString("c"));
        }
    }
}
