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
                    PokeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Pokemon_PokeType_PokeTypeId",
                        column: x => x.PokeTypeId,
                        principalTable: "PokeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0bec55ee-9543-4ddd-a3d4-387d88a8da2e"), "Bug" });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6ab47786-771e-423f-9d06-f380be8ee1fe"), "Dark" });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("60ad7c7c-f8f9-40c2-ba93-4a64f135d44a"), "Fire" });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AbilityId",
                table: "Pokemon",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokeTypeId",
                table: "Pokemon",
                column: "PokeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "PokeType");
        }
    }
}
