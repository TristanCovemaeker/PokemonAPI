using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ability",
                keyColumn: "Id",
                keyValue: new Guid("bb417cc9-14aa-4811-8729-1848063aa42c"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("0354ced6-3921-4d92-9ec0-9108ea3be2c5"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("1de659a5-6f31-4cc1-bbf6-7c8c1b704ab5"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("6785295f-64ce-449c-ae88-70c340af920d"));

            migrationBuilder.InsertData(
                table: "Ability",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a632832b-1b7c-4c70-ada3-a7b81ee85688"), "Levitate" });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f59f08fc-9fe0-467b-b23e-1bec26a1b820"), "Rock" },
                    { new Guid("a01b79db-e726-46b9-ab03-0651318e2c5b"), "Psychic" },
                    { new Guid("57eb19bc-f541-4fa6-80e0-006c8a9d7f2e"), "Poison" },
                    { new Guid("ecdf7d75-0c2b-4d9a-b7eb-ce0b5ba897b3"), "Normal" },
                    { new Guid("bacce8ec-ccd9-4a8d-b614-29772f8a7239"), "Ice" },
                    { new Guid("379f1079-43a4-4c85-a2ba-950aaf759b3c"), "Ground" },
                    { new Guid("8739607a-f06e-4830-a7c3-63df515f7ab5"), "Grass" },
                    { new Guid("811e67bb-8aa0-483b-9782-c76b903c3161"), "Steel" },
                    { new Guid("f7ace123-fe41-44b6-baae-8b6f1afcb427"), "Ghost" },
                    { new Guid("aab44de6-466f-445b-b916-8717a6ecc355"), "Fire" },
                    { new Guid("33b4f16b-06fd-4c9e-b91c-9d14ec96f60a"), "Fight" },
                    { new Guid("898747df-85ba-428a-8ed5-c4c97fe5eab2"), "Fairy" },
                    { new Guid("c1453344-e114-45e4-a668-47b17b0a523e"), "Electric" },
                    { new Guid("2e6164f9-a847-4617-876c-372e3022e9da"), "Dragon" },
                    { new Guid("091d43b4-fc83-4c9f-ab95-159179dfec73"), "Dark" },
                    { new Guid("fcee7abb-957e-475e-9ebd-0d55e2c3230a"), "Bug" },
                    { new Guid("795f4790-b3b6-4e20-b160-cb69128269d7"), "Flying" },
                    { new Guid("3559726c-4a4b-4bdf-81fe-7cdc45748dc4"), "Water" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ability",
                keyColumn: "Id",
                keyValue: new Guid("a632832b-1b7c-4c70-ada3-a7b81ee85688"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("091d43b4-fc83-4c9f-ab95-159179dfec73"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("2e6164f9-a847-4617-876c-372e3022e9da"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("33b4f16b-06fd-4c9e-b91c-9d14ec96f60a"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("3559726c-4a4b-4bdf-81fe-7cdc45748dc4"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("379f1079-43a4-4c85-a2ba-950aaf759b3c"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("57eb19bc-f541-4fa6-80e0-006c8a9d7f2e"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("795f4790-b3b6-4e20-b160-cb69128269d7"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("811e67bb-8aa0-483b-9782-c76b903c3161"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("8739607a-f06e-4830-a7c3-63df515f7ab5"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("898747df-85ba-428a-8ed5-c4c97fe5eab2"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("a01b79db-e726-46b9-ab03-0651318e2c5b"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("aab44de6-466f-445b-b916-8717a6ecc355"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("bacce8ec-ccd9-4a8d-b614-29772f8a7239"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("c1453344-e114-45e4-a668-47b17b0a523e"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("ecdf7d75-0c2b-4d9a-b7eb-ce0b5ba897b3"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("f59f08fc-9fe0-467b-b23e-1bec26a1b820"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("f7ace123-fe41-44b6-baae-8b6f1afcb427"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("fcee7abb-957e-475e-9ebd-0d55e2c3230a"));

            migrationBuilder.InsertData(
                table: "Ability",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bb417cc9-14aa-4811-8729-1848063aa42c"), "Levitate" });

            migrationBuilder.InsertData(
                table: "PokeType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0354ced6-3921-4d92-9ec0-9108ea3be2c5"), "Bug" },
                    { new Guid("1de659a5-6f31-4cc1-bbf6-7c8c1b704ab5"), "Dark" },
                    { new Guid("6785295f-64ce-449c-ae88-70c340af920d"), "Fire" }
                });
        }
    }
}
