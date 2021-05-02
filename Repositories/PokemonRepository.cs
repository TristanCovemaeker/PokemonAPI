using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IPokemonRepository
    {
        Task<Pokemon> GetPokemonByName(string name);
        Task<Pokemon> DeletePokemon(Guid id);
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

        public async Task<Pokemon> GetPokemonByName(string name){
            return await _context.Pokemon.Where(b => b.Name == name).SingleOrDefaultAsync<Pokemon>();
        }

        public async Task<Pokemon> AddPokemon(Pokemon pokemon)
        {
            await _context.Pokemon.AddAsync(pokemon);
            await _context.SaveChangesAsync();
            return pokemon;
        }

         public async Task<Pokemon> DeletePokemon(Guid id){
            var pokemon = await _context.Pokemon.Where(b => b.Id == id).SingleOrDefaultAsync<Pokemon>();
            if(pokemon != null){
                _context.Pokemon.Remove(pokemon);
                await _context.SaveChangesAsync();
            }
            return pokemon;
        }
    }
}
