using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Ticket
    {
        private string Time;
        private string Age;
        private double Cost;
        public static int NumberOfTickets = 0;
        public static double CostOfTickets = 0;

        public Ticket(string time, string age, double cost)
        {
            this.Time = time;
            this.Age = age;
            this.Cost = cost;
        }

        public void GetMatineeTicketData()
        {
            System.Console.Write("How many Child tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
            System.Console.Write("How many Adult tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
            System.Console.Write("How many Senior tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
        }

        public static void GetEveningTicketData()
        {
            System.Console.Write("How many Child tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
            System.Console.Write("How many Adult tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
            System.Console.Write("How many Senior tickets? ");
            //CostOfTickets = int.Parse(System.Console.ReadLine())
        }
    }
}
