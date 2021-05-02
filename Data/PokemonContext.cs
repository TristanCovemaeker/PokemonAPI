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
                    Name = "Fire"
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
