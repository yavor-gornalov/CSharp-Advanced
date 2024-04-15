namespace RawData
{
    internal class StartUp
    {
        static void Main()
        {

            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>(numberOfCars);

            for (int i = 0; i < numberOfCars; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var model = tokens[0];
                var engineSpeed = double.Parse(tokens[1]);
                var enginePower = double.Parse(tokens[2]);
                var cargoWeight = double.Parse(tokens[3]);
                var cargoType = tokens[4];
                var tire1Pressure = double.Parse(tokens[5]);
                var tire1Age = int.Parse(tokens[6]);
                var tire2Pressure = double.Parse(tokens[7]);
                var tire2Age = int.Parse(tokens[8]);
                var tire3Pressure = double.Parse(tokens[9]);
                var tire3Age = int.Parse(tokens[10]);
                var tire4Pressure = double.Parse(tokens[11]);
                var tire4Age = int.Parse(tokens[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tireSet = new Tire[4] {
                    new Tire(tire1Age, tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure),
                };

                var car = new Car(model, engine, cargo, tireSet);
                cars.Add(car);
            }

            var filter = Console.ReadLine();

            if (filter == "fragile")
                cars
                    .Where(x => x.Cargo.Type == filter && x.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.ToString()));
            else if (filter == "flammable")
                cars
                   .Where(x => x.Cargo.Type == filter && x.Engine.Power > 250)
                   .ToList()
                   .ForEach(x => Console.WriteLine(x.ToString()));

        }
    }
}
