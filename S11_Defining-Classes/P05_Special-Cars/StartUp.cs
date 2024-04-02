namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "No more tires")
                    break;

                var tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Tire[] tireSet = new Tire[4];
                for (int i = 1; i < tokens.Length; i += 2)
                {
                    int year = int.Parse(tokens[i - 1]);
                    double pressure = double.Parse(tokens[i]);
                    tireSet[i / 2] = new Tire(year, pressure);
                }
                tires.Add(tireSet);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Engines done")
                    break;

                var tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Show special")
                    break;

                var tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
            }

            foreach (Car car in cars)
            {
                var tirePressure = car.Tires.Select(x => x.Pressure).Sum();
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tirePressure > 9 && tirePressure < 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }

            }
        }
    }
}
