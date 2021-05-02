using System;

namespace PokemonAPI.Models
{
    public class AbilityPokemon
    {
        public Guid AbilityPokemonId { get; set; }
        public string Name { get; set; }
        public Ability PokemonId { get; set; }
    }
}
