namespace CarManufacturer
{
    public class Car
    {
        private string make;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string model;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int year;
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * this.fuelConsumption;
            if (this.fuelQuantity < fuelNeeded)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            this.fuelQuantity -= fuelNeeded;
        }

        public string WhoAmI()
        {
            string message = $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:F2}";
            return message;
        }
    }
}