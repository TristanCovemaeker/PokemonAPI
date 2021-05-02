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
        [Route("type/{NAME}")]
        public async Task<PokeType> GetPokeTypeByName(string NAME){
            return await _pokemonservice.GetPokeTypeByName(NAME);
        }

        [HttpPost]
        [Route("type")]
        public async Task<ActionResult<PokeType>> AddPokeType(PokeType pokeType){
            try{
                return await _pokemonservice.AddPokeType(pokeType);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        [Route("type")]
        public async Task<ActionResult<PokeType>> DeletePokeType(Guid ID){
            try{
                return await _pokemonservice.DeletePokeType(ID);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("abilities")]
        public async Task<List<Ability>> GetAbilities(){
            return await _pokemonservice.GetAbilities();
        }

        [HttpGet]
        [Route("ability/{NAME}")]
        public async Task<Ability> GetAbilityByName(string NAME){
            return await _pokemonservice.GetAbilityByName(NAME);
        }

        [HttpPost]
        [Route("ability")]
        public async Task<ActionResult<Ability>> AddAbility(Ability pokemon){
            try{
                return await _pokemonservice.AddAbility(pokemon);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete]
        [Route("ability")]
        public async Task<ActionResult<Ability>> DeleteAbility(Guid ID){
            try{
                return await _pokemonservice.DeleteAbility(ID);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }



        [HttpGet]
        [Route("pokemon")]
        public async Task<List<Pokemon>> GetPokemon(){
            return await _pokemonservice.GetPokemon();
        }

        [HttpGet]
        [Route("pokemon/{NAME}")]
        public async Task<Pokemon> GetPokemonByName(string NAME){
            return await _pokemonservice.GetPokemonByName(NAME);
        }

        [HttpPost]
        [Route("pokemon")]
        public async Task<ActionResult<Pokemon>> AddPokemon(Pokemon pokemon){
            try{
                return await _pokemonservice.AddPokemon(pokemon);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }
        
        [HttpDelete]
        [Route("pokemon")]
        public async Task<ActionResult<Pokemon>> DeletePokemon(Guid ID){
            try{
                return await _pokemonservice.DeletePokemon(ID);
            }
            catch(Exception){
                return new StatusCodeResult(500);
            }
        }
    }
}
