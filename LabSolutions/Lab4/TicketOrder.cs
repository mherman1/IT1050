namespace Lab4
{
    class TicketOrder
    {
        private int ChildTickets;
        private int AdultTickets;
        private int SeniorTickets;
        private int NumberOfTickets = 0;
        private const double MatineeChildPrice = 3.99;
        private const double MatineeAdultPrice = 5.99;
        private const double MatineeSeniorPrice = 4.50;
        private const double EveningChildPrice = 6.99;
        private const double EveningAdultPrice = 10.99;
        private const double EveningSeniorPrice = 8.50;
        private double TicketCost = 0;
        private double GrandTotal = 0;

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

        public void SetTicketCost(double concessionCost)
        {
            this.GrandTotal = this.TicketCost + concessionCost;
            System.Console.WriteLine("\nYour Grand Total: " + GrandTotal.ToString("c"));
        }


    }
}
