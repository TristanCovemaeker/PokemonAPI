using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IPokeTypeRepository
    {
        Task<PokeType> GetPokeTypeByName(string name);
        Task<PokeType> DeletePokeType(Guid id);
        Task<PokeType> AddPokeType(PokeType pokeType);
        Task<List<PokeType>> GetPokeTypes();
    }

    public class PokeTypeRepository : IPokeTypeRepository
    {
        private IPokemonContext _context;
        public PokeTypeRepository(IPokemonContext context)
        {
            _context = context;
        }

        public async Task<List<PokeType>> GetPokeTypes()
        {
            return await _context.PokeType.ToListAsync();
        }

        public async Task<PokeType> GetPokeTypesByName(string name){
            return await _context.PokeType.Where(b => b.Name == name).SingleOrDefaultAsync<PokeType>();
        }

        public async Task<PokeType> GetPokeTypeByName(string name)
        {
            return await _context.PokeType.Where(b => b.Name == name).SingleOrDefaultAsync();
        }

        public async Task<PokeType> AddPokeType(PokeType pokeType)
        {
            await _context.PokeType.AddAsync(pokeType);
            await _context.SaveChangesAsync();
            return pokeType;
        }

        public async Task<PokeType> DeletePokeType(Guid id){
            var pokeType = await _context.PokeType.Where(b => b.Id == id).SingleOrDefaultAsync<PokeType>();
            if(pokeType != null){
                _context.PokeType.Remove(pokeType);
                await _context.SaveChangesAsync();
            }
            return pokeType;
        }
    }
}
