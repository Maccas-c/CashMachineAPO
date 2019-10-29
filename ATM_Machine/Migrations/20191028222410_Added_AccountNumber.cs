using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATM_Machine.Migrations
{
    public partial class Added_AccountNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Owner",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"),
                column: "AccountNumber",
                value: "123456789");

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("8f18e657-4611-4ce1-9854-279fa327144c"),
                column: "AccountNumber",
                value: "999999999");

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"),
                column: "AccountNumber",
                value: "111111111");

            migrationBuilder.UpdateData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"),
                column: "AccountNumber",
                value: "234567899");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Owner");
        }
    }
}
