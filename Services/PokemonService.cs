using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PokemonAPI.Models;
using PokemonAPI.Repositories;

namespace PokemonAPI.Services
{
    public interface IPokemonService
    {
        Task<Pokemon> AddPokemon(Pokemon pokemon);
        Task<List<Ability>> GetAbilities();
        Task<List<Pokemon>> GetPokemons();
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
        public async Task<List<Ability>> GetAbilities()
        {
            return await _abilityRepository.GetAbilities();
        }
        public async Task<List<Pokemon>> GetPokemons()
        {
            return await _pokemonRepository.GetPokemon();
        }
        public async Task<Pokemon> AddPokemon(Pokemon pokemon)
        {
            return await _pokemonRepository.AddPokemon(pokemon);
        }
    }
}
