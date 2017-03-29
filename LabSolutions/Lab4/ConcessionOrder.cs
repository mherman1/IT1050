namespace Lab4
{
    class ConcessionOrder
    {
        int SmallSoda;
        int LargeSoda;
        int HotDog;
        int Popcorn;
        int Candy;
        const decimal SmallSodaPrice = 3.50M;
        const decimal LargeSodaPrice = 5.99M;
        const decimal HotDogPrice = 3.99M;
        const decimal PopcornPrice = 4.50M;
        const decimal CandyPrice = 1.99M;
        decimal ConcessionCost = 0.00M;

        public void GetConcessionOrder(string concessionInput)
        {
            if (concessionInput.ToLower().StartsWith("y"))
            {
                System.Console.Write("How many candies? ");
                Candy = int.Parse(System.Console.ReadLine());
                ConcessionCost += (Candy * CandyPrice);
                System.Console.Write("How many bags of popcorn? ");
                Popcorn = int.Parse(System.Console.ReadLine());
                ConcessionCost += (Popcorn * PopcornPrice);
                System.Console.Write("How many hot dogs? ");
                HotDog = int.Parse(System.Console.ReadLine());
                ConcessionCost += (HotDog * HotDogPrice);
                System.Console.Write("How many small sodas? ");
                SmallSoda = int.Parse(System.Console.ReadLine());
                ConcessionCost += (SmallSoda * SmallSodaPrice);
                System.Console.Write("How many large sodas? ");
                LargeSoda = int.Parse(System.Console.ReadLine());
                ConcessionCost += (LargeSoda * LargeSodaPrice);
            }
        }

        public void CandyPromotion()
        {
            if (this.Candy >= 3)
            {
                int FreeCandy = Candy / 3;
                Candy += FreeCandy;
            }
        }

        public void TicketDiscountPromotion(TicketOrder ticketOrder)
        {
            ticketOrder.GetTicketDiscount(Popcorn, LargeSoda);
        }

        public void AddPopcorn()
        {
            Popcorn += 1;
        }

        public void PrintYourConcessionOrder()
        {
            System.Console.WriteLine("\nConcessions: ");
            System.Console.WriteLine("Candy = " + Candy);
            System.Console.WriteLine("Popcorn = " + Popcorn);
            System.Console.WriteLine("Hot Dogs = " + HotDog);
            System.Console.WriteLine("Small Sodas = " + SmallSoda);
            System.Console.WriteLine("Large Sodas = " + LargeSoda);
        }

        public void GetGrandTotal(TicketOrder ticketOrder)
        {
            ticketOrder.PrintGrandTotal(this.ConcessionCost);
        }
    }
}
