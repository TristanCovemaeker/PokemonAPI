using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityPokemon",
                columns: table => new
                {
                    AbilityPokemonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PokemonIdId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityPokemon", x => x.AbilityPokemonId);
                    table.ForeignKey(
                        name: "FK_AbilityPokemon_Ability_PokemonIdId",
                        column: x => x.PokemonIdId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgainstBug = table.Column<float>(type: "real", nullable: false),
                    AgainstDark = table.Column<float>(type: "real", nullable: false),
                    AgainstDragon = table.Column<float>(type: "real", nullable: false),
                    AgainstElectric = table.Column<float>(type: "real", nullable: false),
                    AgainstFairy = table.Column<float>(type: "real", nullable: false),
                    AgainstFight = table.Column<float>(type: "real", nullable: false),
                    AgainstFire = table.Column<float>(type: "real", nullable: false),
                    AgainstFlying = table.Column<float>(type: "real", nullable: false),
                    AgainstGhost = table.Column<float>(type: "real", nullable: false),
                    AgainstGrass = table.Column<float>(type: "real", nullable: false),
                    AgainstGround = table.Column<float>(type: "real", nullable: false),
                    AgainstIce = table.Column<float>(type: "real", nullable: false),
                    AgainstNormal = table.Column<float>(type: "real", nullable: false),
                    AgainstPoison = table.Column<float>(type: "real", nullable: false),
                    AgainstPsychic = table.Column<float>(type: "real", nullable: false),
                    AgainstRock = table.Column<float>(type: "real", nullable: false),
                    AgainstSteel = table.Column<float>(type: "real", nullable: false),
                    AgainstWater = table.Column<float>(type: "real", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    BaseEggSteps = table.Column<int>(type: "int", nullable: false),
                    BaseHappiness = table.Column<int>(type: "int", nullable: false),
                    BaseTotal = table.Column<int>(type: "int", nullable: false),
                    CaptureRate = table.Column<int>(type: "int", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    ExperienceGrowth = table.Column<int>(type: "int", nullable: false),
                    HeightM = table.Column<float>(type: "real", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    JapaneseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageMale = table.Column<float>(type: "real", nullable: false),
                    PokedexNumber = table.Column<int>(type: "int", nullable: false),
                    SpAttack = table.Column<int>(type: "int", nullable: false),
                    SpDefense = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    WeightKg = table.Column<float>(type: "real", nullable: false),
                    Generation = table.Column<int>(type: "int", nullable: false),
                    IsLegendary = table.Column<bool>(type: "bit", nullable: false),
                    AbilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokeTypePokemon",
                columns: table => new
                {
                    PokemonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PokeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeTypePokemon", x => new { x.PokemonId, x.PokeTypeId });
                    table.ForeignKey(
                        name: "FK_PokeTypePokemon_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokeTypePokemon_PokeType_PokeTypeId",
                        column: x => x.PokeTypeId,
                        principalTable: "PokeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d92439b1-867a-41ba-a19b-41f169662960"), "Bug" },
                    { new Guid("e5348acd-2ca1-4697-a3f7-2daa82a4eb35"), "Dark" },
                    { new Guid("9ada388c-956b-45ad-9f6f-a4e1d735120f"), "Fire" }
                });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "AbilityId", "AgainstBug", "AgainstDark", "AgainstDragon", "AgainstElectric", "AgainstFairy", "AgainstFight", "AgainstFire", "AgainstFlying", "AgainstGhost", "AgainstGrass", "AgainstGround", "AgainstIce", "AgainstNormal", "AgainstPoison", "AgainstPsychic", "AgainstRock", "AgainstSteel", "AgainstWater", "Attack", "BaseEggSteps", "BaseHappiness", "BaseTotal", "CaptureRate", "Classification", "Defense", "ExperienceGrowth", "Generation", "HeightM", "Hp", "IsLegendary", "JapaneseName", "Name", "PercentageMale", "PokedexNumber", "SpAttack", "SpDefense", "Speed", "WeightKg" },
                values: new object[] { new Guid("a3d978ea-3b28-4fad-af3b-ab301f478d5e"), null, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0, 0, 0, 0, 0, null, 0, 0, 0, 0f, 0, false, null, "Bug", 0f, 0, 0, 0, 0, 0f });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityPokemon_PokemonIdId",
                table: "AbilityPokemon",
                column: "PokemonIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AbilityId",
                table: "Pokemon",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokeTypePokemon_PokeTypeId",
                table: "PokeTypePokemon",
                column: "PokeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityPokemon");

            migrationBuilder.DropTable(
                name: "PokeTypePokemon");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokeType");

            migrationBuilder.DropTable(
                name: "Ability");
        }
    }
}
