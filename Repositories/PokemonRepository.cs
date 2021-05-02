using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IPokemonRepository
    {
        Task<Pokemon> AddPokemon(Pokemon pokemon);
        Task<List<Pokemon>> GetPokemon();
    }

    public class PokemonRepository : IPokemonRepository
    {
        private IPokemonContext _context;
        public PokemonRepository(IPokemonContext context)
        {
            _context = context;
        }

        public async Task<List<Pokemon>> GetPokemon()
        {
            return await _context.Pokemon.ToListAsync();
        }

        public async Task<Pokemon> AddPokemon(Pokemon pokemon)
        {
            await _context.Pokemon.AddAsync(pokemon);
            await _context.SaveChangesAsync();
            return pokemon;
        }
    }
}
