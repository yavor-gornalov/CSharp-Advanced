namespace PokemonTrainer
{
    internal class StartUp
    {
        static void Main()
        {
            var trainers = new List<Trainer>();

            string line;
            while ((line = Console.ReadLine()) != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Trainer trainer = GetTrainer(trainers, trainerName);
                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainer.AddPockemon(pokemon);
            }

            string element;
            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    Pokemon pokemon = trainer.pokemons.FirstOrDefault(x => x.Element == element);
                    if (pokemon == null)
                    {
                        for (int i = 0; i < trainer.pokemons.Count; i++)
                        {
                            Pokemon currentPokemon = trainer.pokemons[i];
                            if (currentPokemon.Health > 10)
                                currentPokemon.Health -= 10;
                            else
                            {
                                trainer.RemovePokemon(currentPokemon);
                                i --;
                            }
                        }
                    } else
                    {
                        trainer.NumberOfBadges++;
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
                Console.WriteLine(trainer.ToString());
        }

        private static Trainer? GetTrainer(List<Trainer> trainers, string trainerName)
        {
            return trainers.FirstOrDefault(x => x.Name == trainerName);
        }
    }
}
