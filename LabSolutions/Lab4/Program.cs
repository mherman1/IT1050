using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket MatineeChild = new Ticket("Matinee", "Child", 3.99);
            Ticket MatineeAdult = new Ticket("Matinee", "Adult", 5.99);
            Ticket MatineeSenior = new Ticket("Matinee", "Senior", 4.50);
            Ticket EveningChild = new Ticket("Evening", "Child", 6.99);
            Ticket EveningAdult = new Ticket("Evening", "Adult", 10.99);
            Ticket EveningSenior = new Ticket("Evening", "Senior", 8.50);

            System.Console.WriteLine("Welcome to MovieTickets!");
            System.Console.WriteLine("\nOur discounts and promotions:");
            System.Console.WriteLine("*Buy a popcorn plus a large soda and get $2 off one ticket!");
            System.Console.WriteLine("*Buy 3 or more tickets and get one bag of popcorn free!");
            System.Console.WriteLine("*Buy 3 candies and get the 4th free!");
            System.Console.Write("\nWould you like to attend a matinee or evening showing? ");
            string TimeInput = System.Console.ReadLine();

            if (TimeInput.ToLower().Contains("matinee"))
            {
                Ticket.GetMatineeTicketData();
            }
            else
            {
                Ticket.GetEveningTicketData();
            }

            System.Console.Write("Would you like to purchase concessions? ");
            string COncessionInput = System.Console.ReadLine();

            if (TimeInput.ToLower().StartsWith("y"))
            {

            }
        }
    }
}
