using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATM_Machine.Migrations
{
    public partial class int_to_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pin",
                table: "Card",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"),
                column: "Pin",
                value: "2345");

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"),
                column: "Pin",
                value: "3456");

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"),
                column: "Pin",
                value: "4567");

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"),
                column: "Pin",
                value: "5678");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pin",
                table: "Card",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"),
                column: "Pin",
                value: 2345);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"),
                column: "Pin",
                value: 3456);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"),
                column: "Pin",
                value: 4567);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"),
                column: "Pin",
                value: 5678);
        }
    }
}
