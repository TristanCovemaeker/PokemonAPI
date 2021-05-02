using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private IPokemonService _pokemonservice;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonservice = pokemonService;
        }

        [HttpGet]
        [Route("types")]
        public async Task<List<PokeType>> GetPokeTypes(){
            return await _pokemonservice.GetPokeTypes();
        }

        [HttpGet]
        [Route("abilities")]
        public async Task<List<Ability>> GetAbilities(){
            return await _pokemonservice.GetAbilities();
        }

        [HttpGet]
        [Route("pokemon")]
        public async Task<List<Pokemon>> GetPokemon(){
            return await _pokemonservice.GetPokemon();
        }
    }
}
