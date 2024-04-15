namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }
        private readonly List<Car> cars;

        private readonly int capacity;

        public int Count => this.cars.Count;

        public Car? GetCar(string registrationNumber) => this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        public string AddCar(Car car)
        {
            if (this.GetCar(car.RegistrationNumber) != null)
                return "Car with that registration number, already exists!";
            if (this.cars.Count == this.capacity)
                return "Parking is full!";
            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            Car carToRemove = this.GetCar(registrationNumber);
            if (carToRemove == null)
                return "Car with that registration number, doesn't exist!";
            this.cars.Remove(carToRemove);
            return $"Successfully removed {carToRemove.RegistrationNumber}";
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            registrationNumbers.ForEach(number =>
            {
                Car carToRemove = GetCar(number);
                if (carToRemove != null)
                    this.RemoveCar(number);
            });
        }
    }
}
