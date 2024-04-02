namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            this.horsePower = horsePower;
            this.cubicCapacity = cubicCapacity;
        }

        private int horsePower;
        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        private double cubicCapacity;
        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }
    }
}