using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    internal class Car
    {

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        private double travelledDistance;
        public double TravelledDistance
        {
            get { return this.travelledDistance; }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.travelledDistance = 0.0;
        }

        public void Drive(double amountOfKm)
        {
            double fuelNeeded = amountOfKm * this.FuelConsumptionPerKilometer;
            if (this.FuelAmount < fuelNeeded)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }
            this.travelledDistance += amountOfKm;
            this.FuelAmount -= fuelNeeded;
        }

        public override string ToString() 
            => $"{this.Model} {this.FuelAmount:F2} {this.travelledDistance}";
    }
}
