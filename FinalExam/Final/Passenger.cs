namespace Final
{
    class Passenger
    {
        string Name;
        double Weight;

        public Passenger (string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
