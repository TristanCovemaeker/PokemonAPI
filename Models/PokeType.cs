using System;
using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class PokeType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public List<Pokemon> Pokemon { get; set; }
    }
}
