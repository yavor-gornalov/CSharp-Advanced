namespace SpeedRacing
{
    internal class StartUp
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelConsumptionPerKilometer = double.Parse(tokens[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .ToArray();

                var carModel = tokens[0];
                var amountOfKm = double.Parse(tokens[1]);

                var car = cars.FirstOrDefault(x => x.Model == carModel);
                car.Drive(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
