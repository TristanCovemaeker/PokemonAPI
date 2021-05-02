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
        public async Task<List<PokeType>> GetTypes(){
            return await _pokemonservice.GetPokeTypes();
        }
    }
}
