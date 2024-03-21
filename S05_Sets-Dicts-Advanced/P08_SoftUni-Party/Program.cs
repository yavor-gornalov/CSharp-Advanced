namespace P08_SoftUni_Party
{
    internal class Program
    {
        static void Main()
        {
            var regularReservations = new HashSet<string>();
            var vipReservations = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "PARTY") break;

                if (char.IsNumber(line[0]))
                    vipReservations.Add(line);
                else
                    regularReservations.Add(line);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END") break;

                if (char.IsNumber(line[0]))
                    vipReservations.Remove(line);
                else
                    regularReservations.Remove(line);
            }

            Console.WriteLine(vipReservations.Count + regularReservations.Count);
            foreach (var guest in vipReservations)
                Console.WriteLine(guest);
            foreach (var guest in regularReservations)
                Console.WriteLine(guest);
        }
    }
}
