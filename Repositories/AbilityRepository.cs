using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories
{
    public interface IAbilityRepository
    {
        Task<Ability> GetAbilityByName(string name);
        Task<Ability> AddAbility(Ability ability);
        Task<Ability> DeleteAbility(Guid id);
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

        public async Task<Ability> GetAbilityByName(string name)
        {
            return await _context.Ability.Where(b => b.Name == name).SingleOrDefaultAsync<Ability>();
        }

        public async Task<Ability> AddAbility(Ability ability)
        {
            await _context.Ability.AddAsync(ability);
            await _context.SaveChangesAsync();
            return ability;
        }

        public async Task<Ability> DeleteAbility(Guid id){
            var ability = await _context.Ability.Where(b => b.Id == id).SingleOrDefaultAsync<Ability>();
            if(ability != null){
                _context.Ability.Remove(ability);
                await _context.SaveChangesAsync();
            }
            return ability;
        }
    }
}
