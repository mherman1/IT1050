namespace Lab4._1
{
    class ConcessionOrder
    {
        private int SmallSoda;
        private int LargeSoda;
        private int HotDog;
        private int Popcorn;
        private int Candy;
        private int TicketDiscount;
        private const double SmallSodaPrice = 3.50;
        private const double LargeSodaPrice = 5.99;
        private const double HotDogPrice = 3.99;
        private const double PopcornPrice = 4.50;
        private const double CandyPrice = 1.99;
        private double ConcessionCost = 0;
        
        public void GetConcessionOrder()
        {
            System.Console.Write("How many candies? ");
            this.Candy = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many bags of popcorn? ");
            this.Popcorn = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many hot dogs? ");
            this.HotDog = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many small sodas? ");
            this.SmallSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many large sodas? ");
            this.LargeSoda = int.Parse(System.Console.ReadLine());

            if (this.Popcorn > 0 && this.LargeSoda > 0 && this.Popcorn >= this.LargeSoda)
            {
                this.TicketDiscount = this.LargeSoda;
            }
            else 
            {
                this.TicketDiscount = this.Popcorn;
            }
        }

        public void GetConcessionCost()
        {
            ConcessionCost += (this.SmallSoda * SmallSodaPrice);
            ConcessionCost += (this.LargeSoda * LargeSodaPrice);
            ConcessionCost += (this.HotDog * HotDogPrice);
            ConcessionCost += (this.Popcorn * PopcornPrice);
            ConcessionCost += (this.Candy * CandyPrice);

            if (this.Candy >= 3)
            {
                int FreeCandy = this.Candy / 3;
                this.Candy += FreeCandy;
            }
        }

        public void AddPopcorn()
        {
            this.Popcorn += 1;
        }

        public void TicketPromotion(TicketOrder ticketOrder)
        {
            ticketOrder.TicketPromotionDiscount(this.TicketDiscount);
        }

        public void YourConcessions()
        {
            System.Console.WriteLine("\nYour Concessions: ");
            System.Console.WriteLine("Candy = " + Candy);
            System.Console.WriteLine("Popcorn = " + Popcorn);
            System.Console.WriteLine("Hot Dogs = " + HotDog);
            System.Console.WriteLine("Small Sodas = " + SmallSoda);
            System.Console.WriteLine("Large Sodas = " + LargeSoda);
        }

        public void GetandPrintGrandTotal(TicketOrder ticketOrder)
        {
            ticketOrder.SetTicketCost(this.ConcessionCost);
        }

    }
}


