namespace P07_Parking_Lot
{
    internal class Program
    {
        static void Main()
        {
            var carsInLot = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    if (carsInLot.Count == 0)
                        Console.WriteLine("Parking Lot is Empty");
                    else
                        foreach (var car in carsInLot)
                            Console.WriteLine(car);
                    break;
                }

                var tokens = line.Split(", ").ToArray();

                string command = tokens[0];
                string licensePlate = tokens[1];

                switch (command)
                {
                    case "IN":
                        {
                            carsInLot.Add(licensePlate);
                            break;
                        }
                    case "OUT":
                        {
                            carsInLot.Remove(licensePlate);
                            break;
                        }
                }
            }
        }
    }
}
