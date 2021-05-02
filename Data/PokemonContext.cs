using System;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;

namespace PokemonAPI.Data
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<Against> Against { get; set; }
        public DbSet<PokemonType> PokemonType { get; set; }
    }
}
