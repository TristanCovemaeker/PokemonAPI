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
                            Id = new Guid("bb417cc9-14aa-4811-8729-1848063aa42c"),
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
                            Id = new Guid("0354ced6-3921-4d92-9ec0-9108ea3be2c5"),
                            Name = "Bug"
                        },
                        new
                        {
                            Id = new Guid("1de659a5-6f31-4cc1-bbf6-7c8c1b704ab5"),
                            Name = "Dark"
                        },
                        new
                        {
                            Id = new Guid("6785295f-64ce-449c-ae88-70c340af920d"),
                            Name = "Fire"
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
