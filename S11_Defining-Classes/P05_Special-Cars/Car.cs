namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;

        }

        public Car(string make, string model, int year) : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires;
        }

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

        private Engine engine;
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        private Tire[] tires;
        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }


        public void Drive(double distance)
        {
            double fuelNeeded = distance * this.fuelConsumption / 100.0;
            if (this.fuelQuantity < fuelNeeded)
            {
                //Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            this.fuelQuantity -= fuelNeeded;
        }

        public string WhoAmI()
        {
            string message = $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"HorsePowers: {this.engine.HorsePower}\n" +
                $"FuelQuantity: {this.FuelQuantity}";
            return message;
        }
    }
}