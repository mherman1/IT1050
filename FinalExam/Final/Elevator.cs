namespace Final
{
    class Elevator
    {
        double MaxWeight;
        Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(string name, double weight, int index)
        {
            this.Occupants[index] = new Passenger(name, weight);
        }

        public double GetCurrentWeight()
        {
            double CurrentWeight = 0;
            foreach (Passenger passenger in Occupants)
            {
                CurrentWeight += passenger.GetWeight();
            }
            return CurrentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }

}
