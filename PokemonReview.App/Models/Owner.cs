namespace PokemonReview.App.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gym { get; set; }

        public Country country { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
