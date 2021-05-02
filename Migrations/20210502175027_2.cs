using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonAPI.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("0bec55ee-9543-4ddd-a3d4-387d88a8da2e"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("60ad7c7c-f8f9-40c2-ba93-4a64f135d44a"));

            migrationBuilder.DeleteData(
                table: "PokeType",
                keyColumn: "Id",
                keyValue: new Guid("6ab47786-771e-423f-9d06-f380be8ee1fe"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
