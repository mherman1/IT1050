namespace Lab4
{
    class TicketOrder
    {
        private int ChildTickets;
        private int AdultTickets;
        private int SeniorTickets;
        private int NumberOfTickets = 0;
        private const decimal MatineeChildPrice = 3.99M;
        private const decimal MatineeAdultPrice = 5.99M;
        private const decimal MatineeSeniorPrice = 4.50M;
        private const decimal EveningChildPrice = 6.99M;
        private const decimal EveningAdultPrice = 10.99M;
        private const decimal EveningSeniorPrice = 8.50M;
        private decimal TicketCost = 0.00M;
        private decimal GrandTotal = 0.00M;

        public void GetTicketOrder()
        {
            System.Console.Write("How many Child tickets? ");
            this.ChildTickets = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Adult tickets? ");
            this.AdultTickets = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many Senior tickets? ");
            this.SeniorTickets = int.Parse(System.Console.ReadLine());
            NumberOfTickets += ChildTickets + AdultTickets + SeniorTickets;
        }

        public void GetMatineeTicketCost()
        {
            this.TicketCost += (this.ChildTickets * MatineeChildPrice);
            this.TicketCost += (this.AdultTickets * MatineeAdultPrice);
            this.TicketCost += (this.SeniorTickets * MatineeSeniorPrice);
        }

        public void GetEveningTicketCost()
        {
            this.TicketCost += (this.ChildTickets * EveningChildPrice);
            this.TicketCost += (this.AdultTickets * EveningAdultPrice);
            this.TicketCost += (this.SeniorTickets * EveningSeniorPrice);
        }

        public void PopcornPromotion(ConcessionOrder concessionOrder)
        {
            if (NumberOfTickets >= 3)
            {
                concessionOrder.AddPopcorn();
            }
        }

        public void TicketPromotionDiscount(int ticketDiscount)
        {
            if (ticketDiscount >= NumberOfTickets)
            {
                int DiscountTotal = NumberOfTickets * 2;
                TicketCost -= DiscountTotal;
            }
            else
            {
                int DiscountTotal = ticketDiscount * 2;
                TicketCost -= DiscountTotal;
            }
        }

        public void YourTickets()
        {
            System.Console.WriteLine("\nYour Tickets: ");
            System.Console.WriteLine("Child = " + ChildTickets);
            System.Console.WriteLine("Adult = " + AdultTickets);
            System.Console.WriteLine("Senior = " + SeniorTickets);
            System.Console.WriteLine("Total = " + NumberOfTickets);
        }

        public void SetTicketCost(decimal concessionCost)
        {
            this.GrandTotal = this.TicketCost + concessionCost;
            System.Console.WriteLine("\nYour Grand Total: " + GrandTotal.ToString("c"));
        }


    }
}
