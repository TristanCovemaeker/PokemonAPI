using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PokemonAPI.Models;
using PokemonAPI.Repositories;

namespace PokemonAPI.Services
{
    public interface IPokemonService
    {
        Task<PokeType> GetPokeTypeByName(string name);
        Task<Ability> DeleteAbility(Guid id);
        Task<Ability> AddAbility(Ability ability);
        Task<Ability> GetAbilityByName(string name);
        Task<Pokemon> GetPokemonByName(string name);
        Task<Pokemon> DeletePokemon(Guid id);
        Task<PokeType> DeletePokeType(Guid id);
        Task<PokeType> AddPokeType(PokeType pokeType);
        Task<Pokemon> AddPokemon(Pokemon pokemon);
        Task<List<Ability>> GetAbilities();
        Task<List<Pokemon>> GetPokemon();
        Task<List<PokeType>> GetPokeTypes();
    }

    public class PokemonService : IPokemonService
    {
        private IPokeTypeRepository _pokeTypeRepository;
        private IAbilityRepository _abilityRepository;
        private IPokemonRepository _pokemonRepository;
        public PokemonService(
            IPokeTypeRepository pokeTypeRepository,
            IAbilityRepository abilityRepository,
            IPokemonRepository pokemonRepository
        )
        {
            _pokeTypeRepository = pokeTypeRepository;
            _abilityRepository = abilityRepository;
            _pokemonRepository = pokemonRepository;
        }

        public async Task<List<PokeType>> GetPokeTypes()
        {
            return await _pokeTypeRepository.GetPokeTypes();
        }

        public async Task<PokeType> GetPokeTypeByName(string name)
        {
            return await _pokeTypeRepository.GetPokeTypeByName(name);
        }

        public async Task<PokeType> AddPokeType(PokeType pokeType)
        {
            return await _pokeTypeRepository.AddPokeType(pokeType);
        }

        public async Task<PokeType> DeletePokeType(Guid id)
        {
            return await _pokeTypeRepository.DeletePokeType(id);
        }
        public async Task<List<Ability>> GetAbilities()
        {
            return await _abilityRepository.GetAbilities();
        }

        public async Task<Ability> GetAbilityByName(string name)
        {
            return await _abilityRepository.GetAbilityByName(name);
        }
        public async Task<Ability> AddAbility(Ability ability)
        {
            return await _abilityRepository.AddAbility(ability);
        }
        public async Task<Ability> DeleteAbility(Guid id)
        {
            return await _abilityRepository.DeleteAbility(id);
        }

        public async Task<List<Pokemon>> GetPokemon()
        {
            return await _pokemonRepository.GetPokemon();
        }

        public async Task<Pokemon> GetPokemonByName(string name)
        {
            return await _pokemonRepository.GetPokemonByName(name);
        }
        public async Task<Pokemon> AddPokemon(Pokemon pokemon)
        {
            return await _pokemonRepository.AddPokemon(pokemon);
        }
        public async Task<Pokemon> DeletePokemon(Guid id)
        {
            return await _pokemonRepository.DeletePokemon(id);
        }
    }
}
