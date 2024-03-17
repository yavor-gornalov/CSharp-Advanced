namespace P07_Truck_Tour
{
    internal class Program
    {
        static void Main()
        {
            var pumpStations = new Queue<int[]>();
            int numberOfPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumpStations.Enqueue(Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray());
            }

            for (int station = 0; station < numberOfPumps; station++)
            {
                var currentRoute = new Queue<int[]>(pumpStations);

                int currentFuel = 0;
                int currentDistance = 0;
                bool routeCompleted = true;
                while (true)
                {
                    if (currentRoute.Count == 0) break;

                    var currentPump = currentRoute.Dequeue();

                    currentFuel += currentPump[0];
                    currentDistance += currentPump[1];

                    if (currentFuel < currentDistance)
                    {
                        routeCompleted = false;
                        break;
                    }
                }

                if (routeCompleted)
                {
                    Console.WriteLine(station);
                    break;
                }
                else
                {
                    pumpStations.Enqueue(pumpStations.Dequeue());
                }
            }
        }
    }
}
