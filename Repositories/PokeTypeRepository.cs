using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IPokeTypeRepository
    {
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
    }
}
