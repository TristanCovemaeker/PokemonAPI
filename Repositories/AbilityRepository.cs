using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IAbilityRepository
    {
        Task<List<Ability>> GetAbilities();
    }

    public class AbilityRepository : IAbilityRepository
    {
        private IPokemonContext _context;
        public AbilityRepository(IPokemonContext context)
        {
            _context = context;
        }

        public async Task<List<Ability>> GetAbilities()
        {
            return await _context.Ability.ToListAsync();
        }
    }
}
