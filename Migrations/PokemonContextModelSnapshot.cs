﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonAPI.Data;

namespace PokemonAPI.Migrations
{
    [DbContext(typeof(PokemonContext))]
    partial class PokemonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("PokemonAPI.Models.Ability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ability");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a632832b-1b7c-4c70-ada3-a7b81ee85688"),
                            Name = "Levitate"
                        });
                });

            modelBuilder.Entity("PokemonAPI.Models.PokeType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PokeType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fcee7abb-957e-475e-9ebd-0d55e2c3230a"),
                            Name = "Bug"
                        },
                        new
                        {
                            Id = new Guid("091d43b4-fc83-4c9f-ab95-159179dfec73"),
                            Name = "Dark"
                        },
                        new
                        {
                            Id = new Guid("2e6164f9-a847-4617-876c-372e3022e9da"),
                            Name = "Dragon"
                        },
                        new
                        {
                            Id = new Guid("c1453344-e114-45e4-a668-47b17b0a523e"),
                            Name = "Electric"
                        },
                        new
                        {
                            Id = new Guid("898747df-85ba-428a-8ed5-c4c97fe5eab2"),
                            Name = "Fairy"
                        },
                        new
                        {
                            Id = new Guid("33b4f16b-06fd-4c9e-b91c-9d14ec96f60a"),
                            Name = "Fight"
                        },
                        new
                        {
                            Id = new Guid("aab44de6-466f-445b-b916-8717a6ecc355"),
                            Name = "Fire"
                        },
                        new
                        {
                            Id = new Guid("795f4790-b3b6-4e20-b160-cb69128269d7"),
                            Name = "Flying"
                        },
                        new
                        {
                            Id = new Guid("f7ace123-fe41-44b6-baae-8b6f1afcb427"),
                            Name = "Ghost"
                        },
                        new
                        {
                            Id = new Guid("8739607a-f06e-4830-a7c3-63df515f7ab5"),
                            Name = "Grass"
                        },
                        new
                        {
                            Id = new Guid("379f1079-43a4-4c85-a2ba-950aaf759b3c"),
                            Name = "Ground"
                        },
                        new
                        {
                            Id = new Guid("bacce8ec-ccd9-4a8d-b614-29772f8a7239"),
                            Name = "Ice"
                        },
                        new
                        {
                            Id = new Guid("ecdf7d75-0c2b-4d9a-b7eb-ce0b5ba897b3"),
                            Name = "Normal"
                        },
                        new
                        {
                            Id = new Guid("57eb19bc-f541-4fa6-80e0-006c8a9d7f2e"),
                            Name = "Poison"
                        },
                        new
                        {
                            Id = new Guid("a01b79db-e726-46b9-ab03-0651318e2c5b"),
                            Name = "Psychic"
                        },
                        new
                        {
                            Id = new Guid("f59f08fc-9fe0-467b-b23e-1bec26a1b820"),
                            Name = "Rock"
                        },
                        new
                        {
                            Id = new Guid("811e67bb-8aa0-483b-9782-c76b903c3161"),
                            Name = "Steel"
                        },
                        new
                        {
                            Id = new Guid("3559726c-4a4b-4bdf-81fe-7cdc45748dc4"),
                            Name = "Water"
                        });
                });

            modelBuilder.Entity("PokemonAPI.Models.Pokemon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AbilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("AgainstBug")
                        .HasColumnType("real");

                    b.Property<float>("AgainstDark")
                        .HasColumnType("real");

                    b.Property<float>("AgainstDragon")
                        .HasColumnType("real");

                    b.Property<float>("AgainstElectric")
                        .HasColumnType("real");

                    b.Property<float>("AgainstFairy")
                        .HasColumnType("real");

                    b.Property<float>("AgainstFight")
                        .HasColumnType("real");

                    b.Property<float>("AgainstFire")
                        .HasColumnType("real");

                    b.Property<float>("AgainstFlying")
                        .HasColumnType("real");

                    b.Property<float>("AgainstGhost")
                        .HasColumnType("real");

                    b.Property<float>("AgainstGrass")
                        .HasColumnType("real");

                    b.Property<float>("AgainstGround")
                        .HasColumnType("real");

                    b.Property<float>("AgainstIce")
                        .HasColumnType("real");

                    b.Property<float>("AgainstNormal")
                        .HasColumnType("real");

                    b.Property<float>("AgainstPoison")
                        .HasColumnType("real");

                    b.Property<float>("AgainstPsychic")
                        .HasColumnType("real");

                    b.Property<float>("AgainstRock")
                        .HasColumnType("real");

                    b.Property<float>("AgainstSteel")
                        .HasColumnType("real");

                    b.Property<float>("AgainstWater")
                        .HasColumnType("real");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("BaseEggSteps")
                        .HasColumnType("int");

                    b.Property<int>("BaseHappiness")
                        .HasColumnType("int");

                    b.Property<int>("BaseTotal")
                        .HasColumnType("int");

                    b.Property<int>("CaptureRate")
                        .HasColumnType("int");

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("ExperienceGrowth")
                        .HasColumnType("int");

                    b.Property<int>("Generation")
                        .HasColumnType("int");

                    b.Property<float>("HeightM")
                        .HasColumnType("real");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<bool>("IsLegendary")
                        .HasColumnType("bit");

                    b.Property<string>("JapaneseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PercentageMale")
                        .HasColumnType("real");

                    b.Property<Guid>("PokeTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PokedexNumber")
                        .HasColumnType("int");

                    b.Property<int>("SpAttack")
                        .HasColumnType("int");

                    b.Property<int>("SpDefense")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<float>("WeightKg")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("PokeTypeId");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokemonAPI.Models.Pokemon", b =>
                {
                    b.HasOne("PokemonAPI.Models.Ability", null)
                        .WithMany("Pokemon")
                        .HasForeignKey("AbilityId");

                    b.HasOne("PokemonAPI.Models.PokeType", "PokeType")
                        .WithMany("Pokemon")
                        .HasForeignKey("PokeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokeType");
                });

            modelBuilder.Entity("PokemonAPI.Models.Ability", b =>
                {
                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonAPI.Models.PokeType", b =>
                {
                    b.Navigation("Pokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
