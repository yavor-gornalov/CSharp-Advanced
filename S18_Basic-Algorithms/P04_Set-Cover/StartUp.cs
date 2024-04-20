﻿namespace SetCover
{
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] universe = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfSets = int.Parse(Console.ReadLine());

            int[][] sets = new int[numberOfSets][];

            for (int row = 0; row < numberOfSets; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sets[row] = new int[rowValues.Length];
                for (int col = 0; col < rowValues.Length; col++)
                {
                    sets[row][col] = rowValues[col];
                }
            }

            List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (int[] set in selectedSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }


        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                int[] longestSet = sets
                    .OrderByDescending(s => s.Count(x => universe.Contains(x)))
                    .FirstOrDefault();
                selectedSets.Add(longestSet);
                sets.Remove(longestSet);
                foreach (var num in longestSet)
                    universe.Remove(num);
            }

            return selectedSets;
        }
    }
}
