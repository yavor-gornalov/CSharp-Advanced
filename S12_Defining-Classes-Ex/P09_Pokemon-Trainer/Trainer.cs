namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> pokemons { get; set; }

        public void AddPockemon(Pokemon pokemon) => this.pokemons.Add(pokemon);

        public void RemovePokemon(Pokemon pokemon) => this.pokemons.Remove(pokemon);

        public override string ToString() => $"{this.Name} {this.NumberOfBadges} {this.pokemons.Count}";
    }
}
