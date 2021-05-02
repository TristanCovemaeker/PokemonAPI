using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PokemonAPI.Configuration;
using PokemonAPI.Models;

namespace PokemonAPI.Data
{
    public interface IPokemonContext
    {
        DbSet<Pokemon> Pokemon { get; set; }
        DbSet<Ability> Ability { get; set; }
        DbSet<PokeType> PokeType { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class PokemonContext : DbContext, IPokemonContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<Ability> Ability { get; set; }
        public DbSet<PokeType> PokeType { get; set; }

        private ConnectionStrings _connectionstrings;

        public PokemonContext(DbContextOptions<PokemonContext> options, IOptions<ConnectionStrings> connectionstrings)
        {
            _connectionstrings = connectionstrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionstrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PokeTypePokemon>().HasKey(c => new {c.PokemonId, c.PokeTypeId});
            //modelBuilder.Entity<PokemonAbility>().HasKey(c => new {c.PokemonId, c.AbilityId});
            
            modelBuilder.Entity<PokeType>().HasData
            (
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Bug"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Dark"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Dragon"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Electric"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Fairy"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Fight"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Fire"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Flying"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Ghost"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Grass"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Ground"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Ice"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Normal"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Poison"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Psychic"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Rock"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Steel"
                },
                new PokeType(){
                    Id = Guid.NewGuid(),
                    Name = "Water"
                }
            );

            modelBuilder.Entity<Ability>().HasData
            (
                new Ability(){
                    Id = Guid.NewGuid(),
                    Name = "Levitate"
                }
            );





            
        }
    }
}
