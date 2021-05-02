using System;

namespace PokemonAPI.Models
{
    public class PokeTypePokemon
    {
        public Guid PokemonId { get; set; }
        public Guid PokeTypeId { get; set; }
        public PokeType PokeType { get; set; }
    }
}
