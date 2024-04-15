using System.Reflection;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString() => $"Make: {this.Make}\n" +
            $"Model: {this.Model}\n" +
            $"HorsePower: {this.HorsePower}\n" +
            $"RegistrationNumber: {this.RegistrationNumber}";
    }
}
