namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger p1 = new Passenger("A1", 180);
            Passenger p2 = new Passenger("A2", 220);
            elevator1.AddOccupant(p1, 0);
            elevator1.AddOccupant(p2, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            Passenger p3 = new Passenger("A1", 200);
            Passenger p4 = new Passenger("A2", 200);
            Passenger p5 = new Passenger("A3", 201);
            elevator2.AddOccupant(p3, 0);
            elevator2.AddOccupant(p4, 1);
            elevator2.AddOccupant(p5, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}
