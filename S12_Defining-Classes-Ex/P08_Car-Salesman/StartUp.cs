using System.Drawing;

namespace RawData
{
    internal class StartUp
    {
        static void Main()
        {

            int numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>(numberOfEngines);

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = engineTokens[0];
                int power = int.Parse(engineTokens[1]);
                int displacement = 0;
                string efficiency = "n/a";
                if (engineTokens.Length == 3)
                {
                    if (!int.TryParse(engineTokens[2], out displacement))
                        efficiency = engineTokens[2];
                }
                if (engineTokens.Length == 4)
                {
                    displacement = int.Parse(engineTokens[2]);
                    efficiency = engineTokens[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>(numberOfCars);

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carTokens[0];
                string engineModel = carTokens[1];
                int weight = 0;
                string color = "n/a";
                if (carTokens.Length == 3)
                {
                    if (!int.TryParse(carTokens[2], out weight))
                        color = carTokens[2];
                }
                if (carTokens.Length == 4)
                {
                    weight = int.Parse(carTokens[2]);
                    color = carTokens[3];
                }

                Engine carEngine = engines.First(x => x.Model == engineModel);
                Car car = new Car(model, carEngine, weight, color);
                cars.Add(car);
            }

            cars.ForEach(car => Console.WriteLine(car.ToString()));

        }
    }
}
