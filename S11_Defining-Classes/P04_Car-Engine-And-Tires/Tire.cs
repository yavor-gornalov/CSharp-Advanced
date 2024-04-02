namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
            this.year = year;
            this.pressure = pressure;
        }

        private int year;
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        private double pressure;
        public double Pressure
        {
            get { return this.pressure; }
            set { this.Pressure = value; }
        }
    }
}