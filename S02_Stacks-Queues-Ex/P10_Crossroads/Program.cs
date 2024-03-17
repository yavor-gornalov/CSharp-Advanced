namespace P10_Crossroads
{
    internal class Program
    {
        static void Main()
        {
            int greenLightTime = int.Parse(Console.ReadLine());
            int freeWindowTime = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

            int passedCarsCounter = 0;
            bool crashHappened = false;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    if (!crashHappened)
                    {
                        Console.WriteLine($"Everyone is safe.\n{passedCarsCounter} total cars passed the crossroads.");
                    }
                    break;
                }

                if (command == "green")
                {
                    var green = greenLightTime;
                    var freeWindow = freeWindowTime;
                    string car = string.Empty;
                    while (cars.Count > 0 && green > 0)
                    {
                        car = cars.Dequeue();
                        green -= car.Length;
                        passedCarsCounter++;
                    }
                    if (green + freeWindow < 0)
                    {
                        crashHappened = true;
                        passedCarsCounter--;
                        var characterHit = car[car.Length - Math.Abs(green + freeWindow)];
                        Console.WriteLine($"A crash happened!\n{car} was hit at {characterHit}.");
                        return;
                    }
                    continue;
                }

                cars.Enqueue(command);
            }
        }
    }
}
