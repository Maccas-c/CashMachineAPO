using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATM_Machine.Migrations
{
    public partial class added_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"),
                column: "Number",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"),
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"),
                column: "Number",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"),
                column: "Number",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"),
                column: "Number",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"),
                column: "Number",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"),
                column: "Number",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"),
                column: "Number",
                value: 0);
        }
    }
}
